using automationUserHubCXOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOneTests
{
    [TestClass]
    public class CreateDailyRuleTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void CanCreateADailyRule()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("ivanv.so32@incontact.com")
                .WithPassword("123Test!@#")
                .Login();

            NewDailyRulePage.GoTo();
            NewDailyRulePage.CreateDailyRule("IV_Rule_auto").Create();

            NewDailyRulePage.GoToNewRule();

            Assert.AreEqual(DailyRulePage.Title, "IV_Rule_auto", "Title did not match!");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
