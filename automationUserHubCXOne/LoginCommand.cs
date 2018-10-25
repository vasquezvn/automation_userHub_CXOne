﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace automationUserHubCXOne
{
    public class LoginCommand
    {
        private string password;
        private readonly string userName;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;

            return this;
        }

        public void Login()
        {
            var loginEmailFieldNext = Driver.Instance.FindElement(By.Id("emailFieldNext"));
            loginEmailFieldNext.SendKeys(userName);

            var nextButtonLogin = Driver.Instance.FindElement(By.Id("nextBtn"));
            nextButtonLogin.Click();

            var passField = Driver.Instance.FindElement(By.Id("mfaPassField"));
            passField.SendKeys(password);

            var signInLoginBtn = Driver.Instance.FindElement(By.Id("mfaLoginBtn"));
            signInLoginBtn.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            var tagName = Driver.Instance.FindElements(By.TagName("h1"))[0].Text;

            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("TagName") == tagName);

        }
    }
}