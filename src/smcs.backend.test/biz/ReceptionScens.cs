using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;
using smcs.backend.data.model;
using System;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class ReceptionScens
    {
        [TestMethod]
        public void AthleteWithProperData_CanBeRecepted()
        {
            using (ShimsContext.Create())
            {
                data.access.Fakes.ShimRepository<data.model.Agent>.AllInstances.AddT0 =
                    delegate { return true; };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.AddT0 =
                    delegate { return true; };

                var agnt = new Agent("احمد علوی", 1, "ناصر", "0012034592", new DateTime(1397, 1, 1), "09001234567", "09007654321", 1, 1);
                var mis = new Mission(new DateTime(1397, 1, 1), 1, 1, "امیر حیدری", 1);
                var biz = new BizProvider("lab");
                biz.RegisterTheAgent(mis, agnt); 
            }
        }

        [TestMethod]
        public void AthleteWhoDoesHavePreviusRecords_CanBeReceptedAgain()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Agent_CanBeUpdated()
        {
            using (ShimsContext.Create())
            {
                data.access.Fakes.ShimRepository<data.model.Agent>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.UpdateAgent(new Agent("علی علیانی", 1, "اکبر", "1234567890", new DateTime(1397, 1, 1),
                            "(912)1234567", "(21)12345678", 1, -1)
                    );
            }
        }
    }
}