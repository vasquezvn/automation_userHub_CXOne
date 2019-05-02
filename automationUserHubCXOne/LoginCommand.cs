using OpenQA.Selenium;
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

            Helper.waitForId("nextBtn");

            var nextButtonLogin = Driver.Instance.FindElement(By.Id("nextBtn"));
            nextButtonLogin.Click();

            var passField = Driver.Instance.FindElement(By.Id("mfaPassField"));
            passField.SendKeys(password);

            var signInLoginBtn = Driver.Instance.FindElement(By.Id("mfaLoginBtn"));
            signInLoginBtn.Click();

            Helper.waitForClassName("page-title ng-binding");           
        }
    }
}