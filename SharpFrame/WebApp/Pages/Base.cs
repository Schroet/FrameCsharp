using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SharpFrame.Pages
{
    public class Base
    {
        protected IWebDriver driver;

        public Base(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WriteText(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public void ClearFld(By element)
        {
            driver.FindElement(element).Clear();
        }

        public void Click(By element)
        {
            driver.FindElement(element).Click();
        }


        public void WaitForClickable(By element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).
                Until(ExpectedConditions.ElementToBeClickable(element));

        }

        public void WaitForVisible(By element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).
                Until(ExpectedConditions.ElementIsVisible(element));

        }

        public string GenerateMail()
        {
            Random rnd = new Random();
            int nmb = rnd.Next(1, 1000);
            string Email = "test"+"+"+ nmb + "@mail.com";
            return Email;
        }

        public void SelectFromDropDown(By elementFld, By elementValue )
        {
            WaitForClickable(elementFld);
            Click(elementFld);
            WaitForClickable(elementValue);
            Click(elementValue);

        }

        public string GetText(By element)
        {
            String actual = driver.FindElement(element).Text;
            return actual;
        }

        public void CheckElementPresent(By element)
        {
            Assert.IsNotNull(element);
        }

        public void ChangeLang(By elementFld, By elementVal)
        {
            WaitForVisible(elementFld);
            Click(elementFld);
           // WaitForVisible(elementVal);
            Click(elementVal);
        }
    }
}
