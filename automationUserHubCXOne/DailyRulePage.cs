using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public static void PressCancelButton()
        {
            Driver.Instance.FindElement(By.Id("cancel")).Click();
            Thread.Sleep(2000);
        }
    }
}
