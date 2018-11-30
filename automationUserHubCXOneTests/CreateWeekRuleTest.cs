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
    public class CreateWeekRuleTest
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

            ListWeeklyRulesPage.GoTo()

            NewDailyRulePage.GoTo();
            NewDailyRulePage.CreateDailyRule(Helper.nameGenerator("IVrule")).Create();

            NewDailyRulePage.GoToNewRule();

            Assert.AreEqual(DailyRulePage.getTitle(), DailyRulePage.Title, "Title did not match!");
        }

        [TestCleanup]
        public void Cleanup()
        {
            DailyRulePage.deleteRule();
            Driver.Close();
        }
    }
}
