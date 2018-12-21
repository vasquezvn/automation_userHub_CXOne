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
            Helper.waitForClassName("daily-rules-grid-wrapper");

            Helper.getRowFromTableByName(DailyRulePage.Title).Click();

            //var dailyRulesTable = Driver.Instance.FindElement(By.XPath("//div[@class='ag-body-container']"));

            //var dailyRulesDivs = dailyRulesTable.FindElements(By.ClassName("ag-row-no-focus"));

            //foreach (var dailyRuleRow in dailyRulesDivs)
            //{
            //    if (!dailyRuleRow.Text.Equals(String.Empty))
            //    {
            //        var newDailyRule = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1].Text;

            //        if (newDailyRule.Equals(DailyRulePage.Title))
            //        {
            //            newDailyRuleRow_delete = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
            //            dailyRuleRow.Click();

            //            break;
            //        }
            //    }

            //}
        }

        public static CreateDailyRuleCommand CreateDailyRule(string title)
        {
            return new CreateDailyRuleCommand(title);
        }
    }
}
