using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using System;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class OfficeAssignmentScens
    {
        [TestMethod]
        public void Office_CanAssignOfficeOnAgent()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("احسان محیطی", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                   "(912)1234567", "(21)12345678", 1, -1);
                var offc = new Office("شماره‌۳");
                data.access.Fakes.ShimRepository<Agent>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.RegisterTheAgentOnOffice(agnt, offc.Id);
            }
        }

        [TestMethod]
        public void Office_CanUnassignAgentFormOffice()
        {
            using (ShimsContext.Create())
            {
                var agnt = new Agent("احسان محیطی", 1, "غلام", "1234567890", new DateTime(1397, 1, 1),
                   "(912)1234567", "(21)12345678", 1, -1);
                data.access.Fakes.ShimRepository<Agent>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.RemoveOfficeOfAgent(agnt);
            }
        }        
    }
}
