using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
