using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CuraHealthCare_TestAutomation.Screens
{
    public class Logout : CorePage
    {
      
        By togglemenu = By.XPath("//a[@id='menu-toggle']");
        By logoutbtn = By.XPath("//a[normalize-space()='Logout']");
        By header = By.XPath("//h1[normalize-space()='CURA Healthcare Service']");
        By scrolltoup = By.XPath("//a[@id='to-top']//i");





        public void LogoutWeb()
        {
            driver.FindElement(togglemenu).Click();
            Thread.Sleep(2000);
            driver.FindElement(logoutbtn).Click();
            Thread.Sleep(1000);

            //print the heading
            string headeroftheapp = driver.FindElement(header).Text;
            Console.WriteLine("Logout: " + headeroftheapp);
            Console.WriteLine();
            Thread.Sleep(4000);

            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\IT\\source\\repos\\CuraHealthCare_TestAutomation\\ss", ScreenshotImageFormat.Png);

            Thread.Sleep(1000);

        }

    }
}
