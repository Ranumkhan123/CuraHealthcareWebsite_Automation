using OpenQA.Selenium;
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
        



        public void LoginWithUser(string url)
        {
            IJavaScriptExecutor scroll = (IJavaScriptExecutor)driver;
            //Action Actions = new Action(driver);

            //maximize the window
            driver.Manage().Window.Maximize();

            //open application
            driver.Url = url;
            Thread.Sleep(1000);
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
            driver.FindElement(loginbtn).Click();

            //Enter username and password
            string enterusername = "John Doe";
            string enterpassword = "ThisIsNotAPassword";
            driver.FindElement(username).SendKeys(enterusername);
            driver.FindElement(password).SendKeys(enterpassword);

            //print the username and password
            Console.WriteLine("Username: " + enterusername);
            Console.WriteLine("Password: " + enterpassword); 
            Console.WriteLine();


            //click login button
            driver.FindElement(clickloginbtn).Click();
            Thread.Sleep(2000);

        }
    }
}
