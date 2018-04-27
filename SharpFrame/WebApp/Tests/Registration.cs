using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpFrame.Settings;

namespace SharpFrame.WebApp.Tests
{
    public class Registration : Browser
    {
        [Test]
        public void RegistrationTc1()
        {
            reg.OpenRegPage();
            reg.AddEmail();
        }
    }
}
