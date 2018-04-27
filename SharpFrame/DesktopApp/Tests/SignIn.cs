using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpFrame.Settings;

namespace SharpFrame.DesktopApp.Tests
{
   public class SignIn: AppSetup
    {
        [Test]
        public void LoginIn()
        {
            loginD.addLogin();
            main.GetText();
        }
    }
}
