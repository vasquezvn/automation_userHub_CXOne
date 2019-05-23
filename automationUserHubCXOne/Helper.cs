using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
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

        public static IWebElement getCellFromTableByColumnName(String nameItem, ColumnName tableValue)
        {
            var table = Driver.Instance.FindElement(By.XPath("//div[@class='ag-body-container']"));

            var rows = table.FindElements(By.ClassName("ag-row"));

            IWebElement rowMatch = null;

            foreach (var row in rows)
            {
                if (!row.Text.Equals(String.Empty))
                {
                    var rowName = row.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1].Text;

                    if (rowName.Equals(nameItem))
                    {
                        switch (tableValue)
                        {
                            case ColumnName.Check:
                                rowMatch = row.FindElements(By.ClassName("ag-cell-not-inline-editing"))[0];
                                break;

                            case ColumnName.Name:
                                rowMatch = row.FindElements(By.ClassName("ag-cell-not-inline-editing"))[1];
                                break;

                            case ColumnName.Delete:
                                IEnumerator<IWebElement> enumerator = row.FindElements(By.ClassName("ag-cell-not-inline-editing")).GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                    
                                    if (enumerator.Current.GetAttribute("class").Contains("delete-button-col"))
                                    {
                                        rowMatch = enumerator.Current;
                                        break;
                                    }

                                }

                                break;

                        }

                        break;
                    }
                }

            }

            return rowMatch;
        }
    }

    public enum ColumnName
    {
        Check,Name,Delete,DeleteWeek
    }
}
