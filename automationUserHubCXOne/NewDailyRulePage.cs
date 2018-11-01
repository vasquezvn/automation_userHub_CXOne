using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class NewDailyRulePage
    {
        public static void GoTo()
        {
            var menuOptions = Driver.Instance.FindElement(By.Id("module-picker-link"));
            menuOptions.Click();

            var menuSelectScheduler = Driver.Instance.FindElement(By.Id("select-scheduler"));
            menuSelectScheduler.Click();

            var menuWfmSetup = Driver.Instance.FindElement(By.Id("scheduler-setup-sub-menu-header"));
            menuWfmSetup.Click();

            var menuWfmSetupDailyRule = Driver.Instance.FindElement(By.Id("dailyRule-link"));
            menuWfmSetupDailyRule.Click();

            var newRuleButton = Driver.Instance.FindElement(By.Id("newRule"));
            newRuleButton.Click();

        }

        public static void GoToNewRule()
        {
            var dailyRulesTable = Driver.Instance.FindElement(By.ClassName("daily-rules-grid"));

            var dailyRulesDivs = dailyRulesTable.FindElements(By.ClassName("ag-row ag-row-no-focus"));

            foreach(var dailyRuleRow in dailyRulesDivs)
            {
                var newDailyRule = dailyRuleRow.FindElements(By.ClassName("ag-cell ag-cell-not-inline-editing"))[1];

                if (newDailyRule.Text.Equals(DailyRulePage.Title))
                {
                    newDailyRule.Click();
                    break;
                }
            }

        }

        public static CreateDailyRuleCommand CreateDailyRule(string title)
        {
            return new CreateDailyRuleCommand(title);
        }
    }
}
