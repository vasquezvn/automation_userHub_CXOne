using OpenQA.Selenium;
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
        public static void waitForClassName(String name)
        {
            try
            {
                new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementIsVisible(By.ClassName(name)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void waitForId(String id)
        {
            try
            {
                new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementIsVisible(By.Id(id)));
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
    }
}
