using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace automationUserHubCXOne
{
    public class ListWfm
    {
        public static void GoToSetup(SetupType setupType)
        {
            Driver.Instance.FindElement(By.Id("module-picker-link")).Click();
            Driver.Instance.FindElement(By.Id("select-scheduler")).Click();

            var schedulerSetupItems = Driver.Instance.FindElement(By.Id("scheduler-setup-sub-menu-items"));
            var schedulerSetupItemsLi = schedulerSetupItems.FindElements(By.TagName("li"));

            if (!schedulerSetupItemsLi[1].Displayed)
            {
                Driver.Instance.FindElement(By.Id("scheduler-setup-sub-menu-header")).Click();
            }

            switch (setupType)
            {
                case SetupType.DailyRules:
                    Driver.Instance.FindElement(By.Id("dailyRule-link")).Click();

                    break;

                case SetupType.WeeklyRules:
                    Driver.Instance.FindElement(By.Id("weeklyRules-link")).Click();

                    break;
            }

        }
    }

    public enum SetupType
    {
        DailyRules,
        WeeklyRules
    }
}
