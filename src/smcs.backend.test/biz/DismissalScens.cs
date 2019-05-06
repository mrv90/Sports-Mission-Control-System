using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;
using smcs.backend.data.model;
using System;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class DismissalScens
    {
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AgentWhoAlreadyDismissed_CouldNotBeDismissed()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("احسان کاظمی", 1, "علی‌اصغر", "1234567890", new DateTime(1397, 1, 1),
                    "(912)1234567", "(21)12345678", 1, -1);
                agnt.Enbl = false;
                data.access.Fakes.ShimRepository<data.model.Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return null; };

                var biz = new BizProvider("lab");
                biz.DismissTheAgent(agnt);
            }
        }

        [TestMethod]
        public void AfterAgentBeingRecepted_CanBeDismissed()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("علی علیانی", 1, "اکبر", "1234567890", new DateTime(1397, 1, 1),
                            "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<data.model.Agent>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return agnt; };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new Session(1); };
                data.access.Fakes.ShimRepository<data.model.Agent>.AllInstances.UpdT0 =
                    delegate { return true; };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.DismissTheAgent(agnt);
            }
        }
    }
}
 