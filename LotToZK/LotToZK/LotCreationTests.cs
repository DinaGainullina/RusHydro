using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace RusHydro
{

    [TestFixture]
    public class LotCreationTests : TestBase
    {

        [Test]
        public void LotCreationTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("login1", "123"));
           
            loginHelper.Logout();
        }

    }

}
