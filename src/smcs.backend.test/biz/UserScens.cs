using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using smcs.backend.biz;

namespace smcs.backend.test.biz
{
    [TestClass]
    public class UserScens
    {

        [TestMethod]
        public void UserAfterSuccessfullyLogedIn_CanOpenSession()
        {
            using (ShimsContext.Create())
            {
                data.access.Fakes.ShimRepository<data.model.User>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new data.model.User("John", "user", "123"); };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.AddT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.Login("user", "123");
            }
        }

        [TestMethod]
        public void UserAfterSuccessfullyLogedOut_CanCloseSession()
        {
            using (ShimsContext.Create())
            {
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.RetExpressionOfFuncOfT0Boolean =
                    delegate { return new data.model.Session(1); };
                data.access.Fakes.ShimRepository<data.model.Session>.AllInstances.UpdT0 =
                    delegate { return true; };

                var biz = new BizProvider("lab");
                biz.Logout();
            }
        }

        //[TestMethod]
        //public void UserWhoDoesntHavePssword_CanMakeNewSessionAndStorePassword()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
