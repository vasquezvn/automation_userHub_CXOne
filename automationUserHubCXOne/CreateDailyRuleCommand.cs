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
            Helper.waitForClassName("RuleTitle");
            Driver.Instance.FindElement(By.Name("RuleTitle")).SendKeys(title);

            DailyRulePage.Title = this.title;

            Helper.waitForId("save");

            //When we are working with frames
            //Driver.Instance.SwitchTo().Frame("content-fr");
            //Driver.Instance.SwitchTo().DefaultContent();

            //Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("save")).Click();

        }
    }
}