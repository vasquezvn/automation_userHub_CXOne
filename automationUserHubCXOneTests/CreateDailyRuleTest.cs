using automationUserHubCXOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            ListWfm.GoToSetup(SetupType.DailyRules);

            ListDailyRules.CreateDailyRule(Helper.nameGenerator("IVrule")).Create();

            ListDailyRules.GoToNewRule();

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
