using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpFrame.Pages;
using SharpFrame.Settings;

namespace SharpFrame.Tests
{
   public class GetWhitelisted : Browser
    {
        [Test]
        public void GetWhitelistedFill()
        {
            home.OpenTradelize();
            home.GetWhitelistedClick();
            home.FillWhitelistedForm();
            String actual = home.GetTextWhiteListed();
            Assert.AreEqual("Click here to update your profile.", actual);
        }
    }
}
