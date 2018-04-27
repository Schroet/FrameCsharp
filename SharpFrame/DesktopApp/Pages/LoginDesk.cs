using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SharpFrame.Pages;

namespace SharpFrame.DesktopApp.Pages
{
   public class LoginDesk : BaseD
    {
        public LoginDesk(RemoteWebDriver driver) : base(driver)
        {
        }

        By login = By.Id("TbLogin");
        String loginStr = "TbLogin";
        By password = By.Id("TbPassword");
        String passwordStr = "PasswordBox";
        By password2FA = By.ClassName("");
        By startBtn = By.Id("BtStart");


        public void addLogin()
        {
            WriteText(login, "test");
            WriteText(password, "test");
            ClickBtn(startBtn);
        }

    }

}
