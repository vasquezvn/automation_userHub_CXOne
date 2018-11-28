using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class DailyRulePage
    {
        public static string Title
        {
            get;
            set;
        }

        public static string getTitle()
        {
            Helper.waitForClassName("daily-rules-grid-wrapper");
            var dailyRulesTable = Driver.Instance.FindElement(By.XPath("//div[@class='ag-body-container']"));
            var dailyRulesDivs = dailyRulesTable.FindElements(By.ClassName("ag-row-no-focus"));
            var newDailyRuleTitle = String.Empty;

            foreach (var dailyRuleRow in dailyRulesDivs)
            {
                if (!dailyRuleRow.Text.Equals(String.Empty))
                {
                    var newDailyRule = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1].Text;

                    if (newDailyRule.Equals(DailyRulePage.Title))
                    {
                        newDailyRuleTitle = newDailyRule;
                        NewDailyRulePage.newDailyRuleRow_delete = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];

                        break;
                    }
                }

            }
            return newDailyRuleTitle;
        }

        public static void deleteRule()
        {
            try
            {
                NewDailyRulePage.newDailyRuleRow_delete.Click();

                var deletebtn = Driver.Instance.FindElement(By.Id("yesBtn"));
                deletebtn.Click();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error on: " + ex.Message);
            }

        }
    }
}
