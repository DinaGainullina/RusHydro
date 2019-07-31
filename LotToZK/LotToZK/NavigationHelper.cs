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
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper(IWebDriver driver, string baseURL)
            : base(driver)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/Account/LogIn");
        }


        public void GoToVotingQuestionCZK()
        {
            Wait(By.Id("ui-accordion-main-header-6"));
            Wait(By.Id("ui-id-93"));
        }
    }
}
