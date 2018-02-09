using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFrame.Pages
{
    public class Home : Base
    {

        public Home(IWebDriver driver) : base(driver)
        {
        }

        By searchFld = By.CssSelector("#lst-ib");
        By findBtn = By.CssSelector(".jsb>center>input");
        By findBtnText = By.PartialLinkText("Пошук Google");

        public void TestRequest()
        {
            WriteText(searchFld, "new test request");
            driver.FindElement(findBtn).SendKeys(Keys.Enter);
            ClearFld(searchFld);
            WriteText(searchFld, "Text from the base class");
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }

    }
}

