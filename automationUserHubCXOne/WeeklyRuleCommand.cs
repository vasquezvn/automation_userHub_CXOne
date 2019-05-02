using OpenQA.Selenium;
using System.Threading;

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

            var dropdownlist = Driver.Instance.FindElement(By.XPath("//input[@class='ui-select-search ui-select-toggle ng-pristine ng-untouched ng-valid ng-empty']"));

            Helper.chooseValueDropdownList(dropdownlist, dailyRulename);

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
            WeeklyRulePage.Title = this.weeklyRuleName;

            Driver.Instance.FindElement(By.Id("employee-tab")).Click();
            Driver.Instance.FindElement(By.LinkText("Add Employees")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='ng-pristine ng-untouched ng-valid ng-empty search-on-keypress']")).SendKeys(Helper.GetCurrentUser());

            Thread.Sleep(2000);

            Driver.Instance.FindElement(By.LinkText("Select All")).Click();

            Thread.Sleep(2000);


            Driver.Instance.FindElement(By.Id("set-selected-users")).Click();

            Thread.Sleep(2000);


            Driver.Instance.FindElement(By.Id("save")).Click();

            Thread.Sleep(2000);
        }
    }
}