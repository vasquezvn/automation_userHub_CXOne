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
                if(Driver.Instance.FindElement(By.XPath("//h3[@class='modal-title ng-binding']")).Displayed)
                    Driver.Instance.FindElement(By.Id("cancel")).Click();

                //ListDailyRules.newDailyRuleRow[5];

                //ListDailyRules.newDailyRuleRow_delete.Click();

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
