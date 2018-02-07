using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharpFrame.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFrame.Settings
{
    public class Browser
    {
        public IWebDriver driver;
        public Home home;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            home = new Home(driver);
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

