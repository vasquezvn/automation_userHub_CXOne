using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace automationUserHubCXOne
{
    internal class Driver
    {
        public static IWebDriver Instance { get; internal set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            
        }
    }
}