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
            return Driver.Instance.FindElement(By.Name("RuleTitle")).GetAttribute("value");
        }

        public static void deleteRule()
        {
            try
            {
                var cancelBtn = Driver.Instance.FindElement(By.Id("cancel"));
                cancelBtn.Click();

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
