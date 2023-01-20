using CuraHealthCare_TestAutomation.Screens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CuraHealthCare_TestAutomation
{
    [TestClass]
    public class TestCases : CorePage
    { 
        Login login = new Login();
        MakeAppointment appointment = new MakeAppointment(); 
        Logout logout = new Logout();



        //The TestInitialize attribute is needed when we want to run a function before executing a test.
        [TestInitialize]
        public void TestInit()
        {
            CorePage.SeleniumInit();
        }


        //The TestCleanup will run after every test execution.
        [TestCleanup]
        public void CleanUp() => driver.Quit();


        [TestMethod]
        public void TC01LogintoWebsite()
        {
            login.LoginWithUser("https://katalon-demo-cura.herokuapp.com/");
            appointment.AppointmentForm();
            logout.LogoutWeb();

        }



    }
}
