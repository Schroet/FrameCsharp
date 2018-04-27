using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SharpFrame.Pages;
using SharpFrame.WebApp.Pages;

namespace SharpFrame.WebApp.Pages
{
    public class Registration : Base
    {
        public Registration(IWebDriver driver) : base(driver)
        {
        }

        By emailFld = By.Id("registration_username");
        By signupBtn = By.CssSelector(".btn-gradient");


        public void OpenRegPage()
        {
            driver.Navigate().GoToUrl("https://tradelizedemo.azurewebsites.net/Auth/Registration");
        }


        public void AddEmail()
        {
            WaitForClickable(emailFld);
            WriteText(emailFld, "new test request");
            driver.FindElement(signupBtn).Click();
        }
    }
}

