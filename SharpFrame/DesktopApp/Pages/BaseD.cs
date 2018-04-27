using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SharpFrame.DesktopApp.Pages
{
   public class BaseD
    {
        protected RemoteWebDriver driver;

        public BaseD(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public void WriteText(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public void ClickBtn(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}
