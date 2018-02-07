using NUnit.Framework;
using SharpFrame.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFrame.Tests
{
    public class LoginTests : Browser
    {
        [Test]
        public void Test1()
        {

            home.OpenPage();
            home.TestRequest();

        }
    }
}

