using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuraHealthCare_TestAutomation.Screens
{
    public class Profiles : CorePage
    {
        By togglemenu = By.XPath("//a[@id='menu-toggle']");
        By profilebtn = By.XPath("//a[normalize-space()='Profile']");
        By profilemessage = By.XPath("//p[normalize-space()='Under construction.']");



        public void ProfilesTab()
        {
            driver.FindElement(togglemenu).Click();
            driver.FindElement(profilebtn).Click();

            //Profile message
            string profilescreenmessage = driver.FindElement(profilemessage).Text;
            Console.WriteLine("Profile: " + profilescreenmessage);
            Console.WriteLine();




        }
    }
}
