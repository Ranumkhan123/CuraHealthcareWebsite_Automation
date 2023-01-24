using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuraHealthCare_TestAutomation.Screens
{
    public class History  : CorePage
    {
        By togglemenu = By.XPath("//a[@id='menu-toggle']");
        By historybtn = By.XPath("//a[normalize-space()='History']");
        By appointments = By.XPath("//body/section[@id='history']/div/div/div[1]/div[1]/div[1]");


        public void HistoryScreen()
        {
            driver.FindElement(togglemenu).Click();
            driver.FindElement(historybtn).Click();

            //Profile message
            string appointmentsmessage = driver.FindElement(appointments).Text;
            Console.WriteLine("History: " + appointmentsmessage);
            Console.WriteLine();
        }
    }
}
