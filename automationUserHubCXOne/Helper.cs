﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automationUserHubCXOne
{
    public class Helper
    {
        public static void waitForClassName(String name, int waitTime = 15)
        {
            try
            {
                new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(waitTime)).Until(ExpectedConditions.ElementIsVisible(By.ClassName(name)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void waitForId(String id, int waitTime = 15)
        {
            try
            {
                new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(waitTime)).Until(ExpectedConditions.ElementIsVisible(By.Id(id)));

                //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                //wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static String nameGenerator(String name)
        {
            String nameg = name + "_" + DateTime.Now.ToString("HH:mm_yyyy");

            return nameg;
        }

        public static string GetCurrentUser()
        {
            var userName = Driver.Instance.FindElement(By.Id("simple-dropdown")).Text.Trim().Split('\r')[0];

            return userName;
        }

        public static void chooseValueDropdownList(IWebElement dropdownlist, String value)
        {
            dropdownlist.Click();
            var dropdownlistvalues = Driver.Instance.FindElements(By.XPath("//div[@class='ui-select-choices-row ng-scope']"));

            foreach (var dropdownlistvalue in dropdownlistvalues)
            {
                if (dropdownlistvalue.Text.Equals(value))
                {
                    dropdownlistvalue.Click();
                    break;
                }
            }
        }

        public static IWebElement[] getRowFromTableByName(String nameItem)
        {
            var table = Driver.Instance.FindElement(By.XPath("//div[@class='ag-body-container']"));
            var rows = table.FindElements(By.ClassName("ag-row-no-focus"));
            object[] rowResults = null;

            foreach (var row in rows)
            {
                if (!row.Text.Equals(String.Empty))
                {
                    var rowName = row.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1].Text;

                    if (rowName.Equals(nameItem))
                    {
                        //rowResults = row.FindElements(By.ClassName("ag-cell-not-inline-editing"));

                        //newDailyRuleRow_delete = row.FindElements(By.ClassName("ag-cell-not-inline-editing"))[5];
                        //dailyRuleRow.Click();

                        break;
                    }
                }

            }

            //return (IWebElement)rowResult;
            return null;
        }
    }
}
