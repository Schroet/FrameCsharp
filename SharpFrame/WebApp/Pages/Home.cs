using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SharpFrame.Pages
{
    public class Home : Base
    {

        public Home(IWebDriver driver) : base(driver)
        {
        }

        By searchFld = By.CssSelector("#lst-ib");
        By findBtn = By.CssSelector(".jsb>center>input");
        By getWhitelisted = By.CssSelector(".fixed-footer__link.fixed-footer--whitelisted");

        //Whitelist pop up
        By fullName = By.CssSelector("#mce-FNAME");
        By emailAddress = By.CssSelector("#mce-EMAIL");
        By traderFld = By.CssSelector("#mce-TYPE");
        By traderValue = By.CssSelector(".popup__val-tr");
        By amount = By.CssSelector("#mce-CURRENCY");
        By residentUSA = By.CssSelector("#IsResident");
        By getInBtn = By.CssSelector(".button.popup__whitelist-submit");

        By successText = By.CssSelector("#messageBox>a");
        By successPopUp = By.CssSelector(".popup__wrapper.popup__wrapper--whitelist");

        //Dashboard
        By questionIcon = By.CssSelector(".fa.fa-question-circle");

        //Navigation
        By home = By.CssSelector(".header__link.header__link--about");
        By eco = By.CssSelector(".header__link.header__link--product");
        By product = By.CssSelector(".header__link.header__link--tokens");
        By token = By.CssSelector(".header__link.header__link--roadmap");
        By team = By.CssSelector(".header__link.header__link--features");
        By roadMap = By.CssSelector(".header__link.header__link--team");

        //From section
        By hometitle = By.CssSelector(".main__start");
        By ecosystem = By.CssSelector(".section-title.has_sub_title>strong");
        By prodtitle= By.CssSelector(".section-title>strong");
        By tokentitle = By.CssSelector(".section-title>strong");
        By teamtitle = By.CssSelector(".team__title>strong");
        By roadtitle = By.CssSelector(".road__title>strong");

        //Language section
        By langButton = By.CssSelector("#initIco");
        By koreanLang = By.LinkText("/ko-KR");
        By koreanLangxpath = By.XPath("html/body/div[1]/header/div/ul/li[3]/a/img");
        By chinisexpath = By.XPath("html/body/div[1]/header/div/ul/li[4]/a/img");
        By usaxpath = By.XPath("html/body/div[1]/header/div/ul/li[2]/a/img");

        By mainTitle = By.CssSelector(".main__title");


        public void ChangeLanguageKorean()
        {
            ChangeLang(langButton, koreanLangxpath);
            Assert.AreEqual("암호 화폐 거래에서 여러분의 레이저검", GetText(mainTitle));
            ChangeLang(langButton, chinisexpath);
            Assert.AreEqual("您在加密货币交易中的光剑", GetText(mainTitle));
            ChangeLang(langButton, usaxpath);
            Assert.AreEqual("Your laser sword in Cryptocurrency Trading", GetText(mainTitle));
        }

        public void CheckNavigation()
        {
            Click(eco);
            Assert.AreEqual("TRADELIZE", GetText(ecosystem));
            Click(product);
            Assert.AreEqual("TRADELIZE", GetText(prodtitle));
            Click(token);
            Assert.AreEqual("TOKEN WILL", GetText(tokentitle));
            Click(team);
            Assert.AreEqual("TEAM", GetText(teamtitle));
            Click(roadMap);
            Assert.AreEqual("ROADMAP", GetText(roadtitle));
            Click(home);
            Assert.AreEqual("PRESALE STARTS", GetText(hometitle));
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }

        public void OpenTradelize()
        {
            driver.Navigate().GoToUrl("https://tradelizedemo.azurewebsites.net/");
        }

        public void GetWhitelistedClick()
        {
            WaitForClickable(getWhitelisted);
            Click(getWhitelisted);
        }

        public void FillWhitelistedForm()
        {
            WaitForClickable(fullName);
            WriteText(fullName, "John Smith");
            WriteText(emailAddress, GenerateMail());
            SelectFromDropDown(traderFld, traderValue);
            WriteText(amount, "100");
            Click(residentUSA);
            Click(getInBtn);
            WaitForVisible(successPopUp);
            WaitForClickable(successText);
        }

        public string GetTextWhiteListed()
        {
            String actual = GetText(successText);
            return actual;
        }

        public void CheckIcon()
        {
            CheckElementPresent(questionIcon);
        }
    }
}

