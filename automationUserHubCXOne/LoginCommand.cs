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
            
        }
    }
}