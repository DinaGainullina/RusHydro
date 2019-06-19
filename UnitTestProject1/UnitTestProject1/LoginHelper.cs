using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace RusHydro
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(IWebDriver driver)
            : base(driver)
        {
        }
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("User")).Clear();
            driver.FindElement(By.Name("User")).SendKeys(account.Username);
            driver.FindElement(By.Name("Password")).Clear();
            driver.FindElement(By.Name("Password")).SendKeys(account.Password);
            Wait(By.CssSelector("input[type=\"submit\"]"));
        }

        public void Logout()
        {
            driver.FindElement(By.CssSelector("a.top.headerLink.topspritebg.logout-link")).Click();
        }
    }
}
