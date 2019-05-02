using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class WeeklyRulePage
    {
        public static string Title
        {
            get;
            set;
        }

        public static object getTitle()
        {
            return Driver.Instance.FindElement(By.Name("RuleTitle")).GetAttribute("value");
        }
    }
}
