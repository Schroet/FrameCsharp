using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SharpFrame.DesktopApp.Pages
{
   public class MainWindow : BaseD
    {
        public MainWindow(RemoteWebDriver driver) : base(driver)
        {
        }

        By headerType = By.Id("HeaderTab");

        public void GetText()
        {
            string text = driver.FindElement(headerType).GetAttribute("Name");
            Console.Write(text);
        }

    }
}
