using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class ListWeelyRules
    {
        public static WeeklyRuleCommand CreateWeelyRule(String weeklyRuleName)
        {
            return new WeeklyRuleCommand(weeklyRuleName);
        }

        public static void GoToNewRule()
        {
            Helper.waitForClassName("weekly-rules-grid-wrapper");
            IWebElement rowMatch = Helper.getCellFromTableByColumnName(WeeklyRulePage.Title, ColumnName.Name);

            rowMatch.Click();
        }

        public static void DeleteSingleRule(string title)
        {
            Helper.waitForClassName("weekly-rules-grid-wrapper");
            IWebElement rowToDelete = Helper.getCellFromTableByColumnName(title, ColumnName.Delete);
            rowToDelete.Click();

            Driver.Instance.FindElement(By.Id("yesBtn")).Click();
        }
    }
}
