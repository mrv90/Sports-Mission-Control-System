using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;
using smcs.backend.data.model;
using smcs.backend.data.model.iterative;
using System;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class OnDutyScens
    {
        [TestMethod]
        public void Agent_CanReceiveOnDuty()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("مبین فانی", 1, "امیر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return agnt; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<Absence>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.AddT0 =
                        delegate { return true; };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OnDuty>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        public void AgentWhoReceivedOnDuty_OnDutyCouldBeRemoved()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("مبین فانی", 1, "امیر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return agnt; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return new OnDuty(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.UpdT0 =
                        delegate { return true; };

                var biz = new BizProvider("lab");
                biz.RemoveTheAgentsIteration<OnDuty>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AgentWhoRegisteredAsOff_CouldNotBeKnownAsOnDuty()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("مبین فانی", 1, "امیر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return agnt; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return new OffDay(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OnDuty>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AgentWhoRegisteredAsAbsent_CouldNotBeKnownAsOnDuty()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("مبین فانی", 1, "امیر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return agnt; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<Absence>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return new Absence(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OnDuty>(agnt.Id, DateTime.Now.Date);
            }
        }
    }
}
