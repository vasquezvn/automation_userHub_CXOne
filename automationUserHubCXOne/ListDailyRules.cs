using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class ListDailyRules
    {
        public static IWebElement newDailyRuleRowName = null;
        public static IWebElement newDailyRuleRowDelete = null;

        public static void GoToNewRule()
        {
            IWebElement rowMatch = Helper.getRowFromTableByColumnName(DailyRulePage.Title, "daily-rules-grid-wrapper", ColumnName.Name);

            rowMatch.Click();
        }

        public static CreateDailyRuleCommand CreateDailyRule(string title)
        {
            return new CreateDailyRuleCommand(title);
        }

        public static void DeleteSingleRule(string title)
        {
            IWebElement rowToDelete = Helper.getRowFromTableByColumnName(title, "daily-rules-grid-wrapper", ColumnName.Delete);
            rowToDelete.Click();

            Driver.Instance.FindElement(By.Id("yesBtn")).Click();
        }
    }
}
