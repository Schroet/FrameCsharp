using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using SharpFrame.DesktopApp.Pages;
using System.Windows.Automation;
using Winium.Cruciatus.Core;
using Winium.Cruciatus.Extensions;
using System.IO;

namespace SharpFrame.Settings
{
    public class AppSetup
    {
        public LoginDesk loginD;
        public MainWindow main;
        public RemoteWebDriver driver { get; set; }
 
        [SetUp]
        public void Initialize()
        {
            System.Diagnostics.Process.Start("D:\\Avel\\Work\\Java libraries\\Winium\\Winium.Desktop.Driver.exe");
            var dc = new DesiredCapabilities();
            dc.SetCapability("app", "D:\\Avel\\Work\\Builds\\С\\23.04.2018\\3\\Debug\\HybridTerminal.exe");
            this.driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);

            loginD = new LoginDesk(driver);
            main = new MainWindow(driver);
        }



        [TearDown]
        public void Tear()
        {
            driver.Quit();
        }
    }
}
