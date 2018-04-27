using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharpFrame.Pages;
using SharpFrame.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpFrame.WebApp.Pages;

namespace SharpFrame.Settings
{
    public class Browser
    { 
        public IWebDriver driver;
        public Home home;
        public Registration reg;
        public Login login;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Manage().Window.Size = new Size(480, 320);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            home = new Home(driver);
            reg = new Registration(driver);
            login = new Login(driver);
        }

        public static void Main()
        {
           
        }

        [TearDown]
        public void Tear()
        {
            driver.Quit();
        }

    }

}

