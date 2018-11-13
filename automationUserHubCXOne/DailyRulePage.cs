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

    }
}
