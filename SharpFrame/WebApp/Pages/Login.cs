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
   public class Login : Base
    {
        public Login(IWebDriver driver) : base(driver)
        {
        }

        By userFld = By.CssSelector("#signin_username");
        By passFld = By.CssSelector("#signin_password");
        By signinBtn = By.CssSelector(".btn-gradient");
        By signupBtn = By.CssSelector(".font-sm.text-center.form-label>a");

        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl("https://tradelizedemo.azurewebsites.net/Auth/SignIn");
            
        }

        public void SignIn()
        {
            WriteText(userFld, "trreg0405@yopmail.com");
            WriteText(passFld, "105165");
            Click(signinBtn);
        }
    }
}
