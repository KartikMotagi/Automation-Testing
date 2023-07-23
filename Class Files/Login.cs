using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Testing.Class_Files
{
    public class Login
    {
        [FindsBy(How = How.Id, Using = "user-name")] IWebElement UserName;

        [FindsBy(How = How.Id, Using = "password")] IWebElement Password;

        [FindsBy(How = How.Id, Using = "login-button")] IWebElement Loginbutton;

        public void Login_Info(String name, String pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            Loginbutton.Click();
        }
    }
}
