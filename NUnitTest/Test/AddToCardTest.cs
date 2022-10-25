using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitTest.Base;
using NUnitTest.Pages;

namespace NUnitTest.Test
{
    class AddToCardTest : TestBase
    {
        [Test]
        public void WhenLoginWithValidNameAndPassword_SuccessMessageShouldAppear()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.LoginWithNameAndPassword("standard_user", "secret_sauce");
            mainPage.CheckThatAlertMessageContainsText("REMOVE");
        }
    }
}
