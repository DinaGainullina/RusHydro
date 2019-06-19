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
    public class QuestionHelper : HelperBase
    {
      
        public QuestionHelper(IWebDriver driver)
            : base(driver)
        {
        }
        public void InitQuestionCreation()
        {
            Wait(By.LinkText("Добавить"));
        }
 
        public void FillQuestionForm(QuestionData questionData)
        {

            Wait(By.Id("data_typeQuestionIdRef_switch"));
            Wait(By.XPath("//div[@id='data_typeQuestionIdRef_result']/table/tbody/tr[2]/td"));
            Wait(By.Id("data_name"));
            driver.FindElement(By.Id("data_name")).Clear();
            driver.FindElement(By.Id("data_name")).SendKeys(questionData.Name);
        }

        public void SubmitQuestionCreation()
        {
            Wait(By.CssSelector("input[type=\"submit\"]"));
            Wait(By.CssSelector("input[type=\"submit\"]"));
        }


    }
}
