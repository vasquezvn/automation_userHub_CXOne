using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using automationUserHubCXOne;

namespace automationUserHubCXOneTests
{
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void UserAdminCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("ivanv.so32@incontact.com")
                .WithPassword("123Test!@#")
                .Login();

            //Assert.IsTrue(DashboardPage.IsAt, "Failed to Login");
        }


    }
}
