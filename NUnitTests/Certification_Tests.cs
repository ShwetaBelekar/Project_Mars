using NUnit.Framework;
using Project_Mars.BaseClass;
using Project_Mars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.NUnitTests
{
    [TestFixture]

    public class Certification_Tests : BaseTest
    {
        [SetUp]
        public void SetUpSteps()
        {
            //driver = new ChromeDriver();

            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginActions(driver);

            //loginPageObj.VerifyUserInHomePage(driver);

            HomeToCertificationsPage homeToCertificationsPageObj = new HomeToCertificationsPage();
            homeToCertificationsPageObj.NavigateToCertifications(driver);
        }
    }
}
