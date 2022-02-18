using eBankingApp.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBankingTests
{
    public  class EBankingApp
    {
        public static int applyLoan(IWebDriver driver,
            string fullyQualifiedUrlLoan)
        {
            driver.Navigate().GoToUrl(fullyQualifiedUrlLoan);
            var getHashCode = Convert.ToInt32(driver.FindElement(By.Id("hashCodeValue")).Text);
            return getHashCode;
        }
    }
}
