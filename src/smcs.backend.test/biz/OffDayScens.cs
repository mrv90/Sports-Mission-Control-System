using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;
using smcs.backend.data.model;
using smcs.backend.data.model.iterative;
using System;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class OffDayScens
    {
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Athlete_CannotReceiveOffDay()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("قاسم مهدیانی", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                agnt.Enbl = false;
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return null; };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OffDay>(agnt.Id, DateTime.Now.Date); 
            }
        }

        [TestMethod]
        public void Agent_CanReceiveOffDay()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("محسن سلیمانی", 1, "امیر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<Absence>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                        delegate { return null; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.AddT0 =
                        delegate { return true; };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OffDay>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        public void AgentWithOffDay_CouldCancelOffDay()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("سینا پرنیان", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new OffDay(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };
                data.access.Fakes.ShimRepository<OffDay>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.RemoveTheAgentsIteration<OffDay>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AgentWhoAlreadyOnDuty_CannotReceiveOffDay()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("سینا پرنیان", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<Absence>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return null; };
                data.access.Fakes.ShimRepository<OnDuty>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new OnDuty(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<OffDay>(agnt.Id, DateTime.Now.Date);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AgentWhoAlreadyAbsent_CannotReceiveOffDay()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("سینا پرنیان", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<Absence>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new Absence(DateTime.Now.Date, agnt.Id, CrntUser.SesId); };

                var biz = new BizProvider("lab");
                biz.WriteTheAgentsIteration<Absence>(agnt.Id, DateTime.Now.Date);
            }
        }
    }
}
    