using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFrame.Pages
{
    public class Home
    {
        IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        By searchFld = By.CssSelector("#lst-ib");
        By findBtn = By.CssSelector(".jsb>center>input");
        By findBtnText = By.PartialLinkText("Пошук Google");

        public void TestRequest()
        {

            driver.FindElement(searchFld).SendKeys("new test request");
            driver.FindElement(findBtn).SendKeys(Keys.Enter);

        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }

    }
}

