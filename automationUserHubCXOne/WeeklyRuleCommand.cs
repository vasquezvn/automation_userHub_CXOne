using OpenQA.Selenium;

namespace automationUserHubCXOne
{
    public class WeeklyRuleCommand
    {
        private string weeklyRuleName;

        public WeeklyRuleCommand(string weeklyRuleName)
        {
            this.weeklyRuleName = weeklyRuleName;
        }

        public WeeklyRuleCommand withDrule(string dailyRulename)
        {
            Driver.Instance.FindElement(By.Id("newRule")).Click();
            Driver.Instance.FindElement(By.Name("RuleTitle")).SendKeys(this.weeklyRuleName);

            //TODO: find better way to locate element
            Driver.Instance.FindElements(By.XPath("//input[@class='ui-select-search']"))[0].SendKeys(dailyRulename);

            var possibleDays = Driver.Instance.FindElements(By.XPath("//div[@class='dayStyle ng-binding ng-scope']"));

            foreach(var possibleDay in possibleDays)
            {
                possibleDay.Click();
            }

            Driver.Instance.FindElement(By.XPath("//button[@class='btn btn-primary btn-sm ng-scope']")).Click();

            return this;
        }

        public void Create()
        {
            Driver.Instance.FindElement(By.LinkText("Employee")).Click();
            Driver.Instance.FindElement(By.LinkText("Add Employees")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='ng-pristine ng-valid ng-empty search-on-keypress ng-touched']")).SendKeys(Helper.GetCurrentUser());
            Driver.Instance.FindElement(By.LinkText("Select All")).Click();
            Driver.Instance.FindElement(By.Id("set-selected-users")).Click();
            Driver.Instance.FindElement(By.Id("save")).Click();
        }
    }
}