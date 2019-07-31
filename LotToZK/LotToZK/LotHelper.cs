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
    public class LotHelper : HelperBase
    {

        public LotHelper(IWebDriver driver)
            : base(driver)
        {
        }
        public void InitLotCreation()
        {
            Wait(By.LinkText("Создать лот"));
        }

        public void FillLotForm(/*LotData lotData*/)
        {

            Wait(By.Id("data_lot_typeRef_switch"));
            Wait(By.XPath("//div[@id='data_lot_typeRef_result']/table/tbody/tr[5]/td"));
            Wait(By.Id("PlanType"));
            new SelectElement(driver.FindElement(By.Id("PlanType"))).SelectByText("Внеплановая дозакупка менее 20%");
            Wait(By.Id("PlanType"));
            Wait(By.Id("data_lot_add_purchaseRef_switch"));
            Wait(By.XPath("//div[@id='data_lot_add_purchaseRef_result']/table/tbody/tr[2]/td[3]"));
            driver.SwitchTo().Alert().Accept();
          //  driver.SwitchTo().Alert().Accept();
           // driver.SwitchTo().Alert().Accept();
            Wait(By.Id("data_purch_commission_idRef_switch"));
            Wait(By.XPath("//div[2]/table/tbody/tr[2]/td[3]"));
            Wait(By.Id("data_purchase_justification_only"));
            Wait(By.Id("data_purchase_justification_only"));
            driver.FindElement(By.Id("data_purchase_justification_only")).SendKeys("123");
            Wait(By.Id("data_purch_justification_document"));
            Wait(By.Id("data_purch_justification_document"));
            driver.FindElement(By.Id("data_purch_justification_document")).SendKeys("123");
            Wait(By.CssSelector("input[type=\"submit\"]"));
        }


    }
}
