using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
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
        [TestCase("mumbai university", "India", "PHD", "Economics", "2007")]
        [TestCase("model college", "Switzerland", "M.B.A", "Commerce", "2020")]
        [TestCase("newyork university", "United States", "MFA", "Science", "2001")]
        [TestCase("american college", "New Zealand", "Associate", "Arts", "2024")]
        public void CreateEducationRecord(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
        }
        public void IsRecordCreatedSuccessfully(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
        {
            IWebElement newuniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newcountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newtitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            IWebElement newdegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            IWebElement newgraduationyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            if (newuniversity.Text == collegeUniversityName && newcountry.Text == countryOfCollegeUniversity && newtitle.Text == title && newdegree.Text == degree && newgraduationyear.Text == yearOfGraduation)
            {
                Assert.Pass("record created successfully");
            }
            else
            {
                Assert.Fail("record creation unsuccessful");
            }

        }
    }
}
