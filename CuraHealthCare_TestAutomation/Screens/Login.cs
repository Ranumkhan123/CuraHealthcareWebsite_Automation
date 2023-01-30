using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CuraHealthCare_TestAutomation.Screens
{
    public class Login : CorePage
    {
        By header = By.XPath("//h1[normalize-space()='CURA Healthcare Service']");
        By togglemenu = By.XPath("//a[@id='menu-toggle']");
        By loginbtn = By.XPath("//a[normalize-space()='Login']");
        By username = By.XPath("//input[@id='txt-username']");
        By password = By.XPath("//input[@id='txt-password']");
        By clickloginbtn = By.XPath("//button[@id='btn-login']");
        By makeappoitmentbtn = By.XPath("//a[@id='btn-make-appointment']");
        



        public void LoginWithUser(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //Action Actions = new Action(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;
            //wait screen visible
            var waittoloadpage = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waittoloadpage.Until(ExpectedConditions.ElementIsVisible(makeappoitmentbtn));

            //print the url
            Console.WriteLine("URL of the application:" + " " + url);
            Console.WriteLine();
            //print the title
            string title = driver.Title;
            Console.WriteLine("Title of the page:" + " " + title);
            Console.WriteLine();

            //print the heading
            string headeroftheapp = driver.FindElement(header).Text;
            Console.WriteLine("Heading: " + headeroftheapp);
            Console.WriteLine();

            //Login to the website
            driver.FindElement(togglemenu).Click();
            //wait 
            var loginbuttonwait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            loginbuttonwait.Until(ExpectedConditions.ElementIsVisible(loginbtn));

            driver.FindElement(loginbtn).Click();

            //wait 
            var usernamevisible = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            usernamevisible.Until(ExpectedConditions.ElementIsVisible(username));

            //Enter username and password
            string enterusername = "John Doe";
            string enterpassword = "ThisIsNotAPassword";
            driver.FindElement(username).SendKeys(enterusername);
            driver.FindElement(password).SendKeys(enterpassword);

            //print the username and password
            Console.WriteLine("Username: " + enterusername);
            Console.WriteLine("Password: " + enterpassword); 
            Console.WriteLine();

            //wait 
            var waittoclickloginbutton = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waittoclickloginbutton.Until(ExpectedConditions.ElementIsVisible(clickloginbtn));

            //click login button
            driver.FindElement(clickloginbtn).Click();
            Thread.Sleep(2000);

        }
    }
}
