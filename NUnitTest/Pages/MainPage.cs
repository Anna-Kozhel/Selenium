using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest.Pages
{
    class MainPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        private IWebElement login { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button")]
        private IWebElement addToCard { get; set; }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void CheckThatAlertMessageContainsText(string message)
        {
            Assert.That(addToCard.Text.ToUpper().Contains(message));
        }

        public MainPage LoginWithNameAndPassword(string name, string pwd)
        {
            username.Click();
            username.Clear();
            username.SendKeys(name);

            password.Click();
            password.Clear();
            password.SendKeys(pwd);

            login.Click();
            addToCard.Click();
            return new MainPage(Driver);
        }
    }
}
