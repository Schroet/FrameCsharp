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
    public class ChangeLanguage : Browser
    {
        [Test]
        public void ChangeLanguages()
        {
            home.OpenTradelize();
            home.ChangeLanguageKorean();
        }
    }
}
