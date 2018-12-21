using OpenQA.Selenium;
using System;
using System.Threading;

namespace automationUserHubCXOne
{
    public class CreateDailyRuleCommand
    {
        private readonly string title;

        public CreateDailyRuleCommand(string title)
        {
            this.title = title;
        }

        public void Create()
        {
            Driver.Instance.FindElement(By.Id("newRule")).Click();

            Helper.waitForClassName("RuleTitle");
            Driver.Instance.FindElement(By.Name("RuleTitle")).SendKeys(title);

            DailyRulePage.Title = this.title;

            Helper.waitForId("save");

            Driver.Instance.FindElement(By.Id("save")).Click();
            Thread.Sleep(1000);

            ListDailyRules.newDailyRuleRow = Helper.getRowFromTableByName(DailyRulePage.Title);
        }
    }
}