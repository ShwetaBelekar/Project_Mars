using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.NUnitTests
{
    [TestFixture]
    public class Education_Tests : CommonDriver
    {
        [SetUp]
       public void SetUpSteps()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            loginPageObj.VerifyUserInHomePage(driver);

            HomeToEducationPage homeToEducationPageObj = new HomeToEducationPage();
            homeToEducationPageObj.NavigateToEducation(driver);
        }
        [Test]
        public void CreateEducation_Test()
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver);
        }
        
    }
}
