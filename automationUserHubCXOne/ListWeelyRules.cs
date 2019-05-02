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

            //Helper.getRowFromTableByName(DailyRulePage.Title).Click();

            var weeklyRulesTable = Driver.Instance.FindElement(By.XPath("//div[@class='ag-body-container']"));

            var weeklyRulesDivs = weeklyRulesTable.FindElements(By.ClassName("ag-row-no-focus"));

            foreach (var weeklyRuleRow in weeklyRulesDivs)
            {
                if (!weeklyRuleRow.Text.Equals(String.Empty))
                {
                    var newWeeklyRule = weeklyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1].Text;

                    if (newWeeklyRule.Equals(WeeklyRulePage.Title))
                    {
                        //newDailyRuleRow_delete = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
                        weeklyRuleRow.Click();

                        break;
                    }
                }

            }
        }
    }
}
