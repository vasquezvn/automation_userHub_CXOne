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
        public void CanCreateAWeeklyRule()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("ivanv.so32@incontact.com")
                .WithPassword("123Test!@#")
                .Login();

            ListWfm.GoToSetup(SetupType.DailyRules);

            ListDailyRules.CreateDailyRule(Helper.nameGenerator("IVrule")).Create();

            ListWfm.GoToSetup(SetupType.WeeklyRules);


            ListWeelyRules.CreateWeelyRule(Helper.nameGenerator("IV_WRule")).withDrule(DailyRulePage.Title).Create();
            //ListWeelyRules.GoToNewWRule();

            //Assert.AreEqual(WeeklyRulePage.getTitle(), WeeklyRulePage.Title, "Title did not match!");
        }

        [TestCleanup]
        public void Cleanup()
        {
            //NewWeeklyRulePage.deleteRule();
            DailyRulePage.deleteRule();
            Driver.Close();
        }
    }
}
