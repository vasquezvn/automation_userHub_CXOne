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
            //Helper.waitForClassName("RuleTitle");
            ////var title = Driver.Instance.FindElement(By.Name("RuleTitle"));
            //var title = Driver.Instance.FindElement(By.XPath("//input[@name='RuleTitle']"));

            //if (title != null)
            //    return title.Text;
            //return String.Empty;

            // new code
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

                        //newDailyRuleRow = dailyRuleRow;
                        //dailyRuleRow.Click();

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

            //if (!NewDailyRulePage.newDailyRuleRow_delete.Equals(null))
            //{
            //    NewDailyRulePage.newDailyRuleRow_delete.Click();

                //var cancelBtn = Driver.Instance.FindElement(By.Id("cancel"));
                //cancelBtn.Click();

                //var deleteBtn = NewDailyRulePage.newDailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
                //deleteBtn.Click();

                //var yesBtn = deleteBtn.FindElement(By.Id("yesBtn"));
                //yesBtn.Click();



                //var dailyRulesTable = Driver.Instance.FindElement(By.XPath("/html/body/div[1]/main/div/div/div[2]/div/div/nice-grid/div/div[2]/div/div/div/div[3]/div[2]"));

                //var dailyRulesDivs = dailyRulesTable.FindElements(By.ClassName("ag-row-no-focus"));

                //foreach (var dailyRuleRow in dailyRulesDivs)
                //{
                //    if (!dailyRuleRow.Text.Equals(String.Empty))
                //    {
                //        var deleteBtn = dailyRuleRow.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
                //        deleteBtn.Click();

                //        var yesBtn = deleteBtn.FindElement(By.Id("yesBtn"));
                //        yesBtn.Click();
                        
                //    }

                //}
            //}
        }
    }
}
