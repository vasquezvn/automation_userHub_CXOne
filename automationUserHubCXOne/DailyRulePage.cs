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
            //get
            //{
            //    var title = Driver.Instance.FindElement(By.Name("RuleTitle"));

            //    if (title != null)
            //        return title.Text;
            //    return String.Empty;
            //}
            set;
        }

        public static string getTitle()
        {
            var title = Driver.Instance.FindElement(By.Name("RuleTitle"));

            if (title != null)
                return title.Text;
            return String.Empty;
        }

        public static void deleteRule(string title)
        {
            if (!title.Equals(String.Empty))
            {
                var cancelBtn = Driver.Instance.FindElement(By.Id("cancel"));
                cancelBtn.Click();

                var dailyRulesTable = Driver.Instance.FindElement(By.XPath("/html/body/div[1]/main/div/div/div[2]/div/div/nice-grid/div/div[2]/div/div/div/div[3]/div[2]"));

                var dailyRulesDivs = dailyRulesTable.FindElements(By.ClassName("ag-row-no-focus"));

                foreach (var dailyRuleRow in dailyRulesDivs)
                {
                    if (!dailyRuleRow.Text.Equals(String.Empty))
                    {
                        var deleteBtn = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
                        deleteBtn.Click();

                        var yesBtn = deleteBtn.FindElement(By.Id("yesBtn"));
                        yesBtn.Click();
                        
                    }

                }
            }
        }
    }
}
