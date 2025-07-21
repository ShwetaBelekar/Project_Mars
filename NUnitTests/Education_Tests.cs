using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using OpenQA.Selenium.Chrome;
using Project_Mars.BaseClass;
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
    public class Education_Tests : BaseTest
    {

        [SetUp]
        public void SetUpSteps()
        {
            //driver = new ChromeDriver();

            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginActions(driver);

            //loginPageObj.VerifyUserInHomePage(driver);

            HomeToEducationPage homeToEducationPageObj = new HomeToEducationPage();
            homeToEducationPageObj.NavigateToEducation(driver);
        }
        [Test(Description = "Create Valid Education Record")]
        [TestCase("mumbai university", "India", "PHD", "Economics", "2007")]
        [TestCase("model college", "Switzerland", "M.B.A", "Commerce", "2020")]
        [TestCase("newyork university", "United States", "MFA", "Science", "2001")]
        [TestCase("american college", "New Zealand", "Associate", "Arts", "2024")]
        public void CreateValidEducationRecord(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
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
        


        [Test(Description = "Check if the system accepts blank field education record")]
        [TestCase("mumbai university", "India", "PHD", "", "2007")]
        [TestCase("", "India", "PHD", "Economics", "2007")]
        [TestCase("mumbai university", "", "PHD", "Economics", "2007")]
        [TestCase("mumbai university", "India", "", "Economics", "2007")]
        [TestCase("mumbai university", "India", "PHD", "Economics", "")]
        public void TryToCreateEducationRecordWithBlankField(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
            
            string popupAlert = educationPageObj.BlankField(driver);
            if (popupAlert == "Please enter all the fields")
            {
                Assert.Pass("Blank field record not accepted and Popup message says please enter all fields");
            }
            else
            {
                Assert.Fail("Blank field record is accepted and no popup message appears");
            }

        }
        

        [Test(Description = "Create invalid education record")]
        [TestCase("1234", "India", "PHD", "GrassCutting", "2007")]
        [TestCase("ABCDEFGH", "Belgium", "M.B.A", "DrinkingWater", "2008")]
        [TestCase("123@@@@###abcEFG", "Australia", "MFA", "WashingUtensils", "2009")]
        [TestCase("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "China", "B.A", "Cleaning", "2010")]
        [TestCase("@@@@###$$$%%%%^^^", "Zambia", "B.Sc", "Roaming", "2011")]
        public void CreateInvalidEducationRecord(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
            IWebElement newuniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newdegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            if (newuniversity.Text == collegeUniversityName &&  newdegree.Text == degree)
            {
                Assert.Pass("Invalid record accepted error in the system");
            }
            else
            {
                Assert.Fail("Invalid record not accepted no error in the system");
            }
        }
        [Test(Description = "Create Duplicate Education Record")]
        [TestCase("mumbai university", "India", "PHD", "Economics", "2007")]
        

        public void CreateDuplicateEducationRecord(string collegeUniversityName, string countryOfCollegeUniversity, string title, string degree, string yearOfGraduation)
      
        {
            EducationPage educationPageObj = new EducationPage();
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
            IWebElement newuniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newcountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newtitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            IWebElement newdegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            IWebElement newgraduationyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            
            if (newuniversity.Text == collegeUniversityName && newcountry.Text == countryOfCollegeUniversity && newtitle.Text == title && newdegree.Text == degree && newgraduationyear.Text == yearOfGraduation)
            {
                Console.WriteLine("record created successfully");
            }
            else
            {
                Console.WriteLine("record creation unsuccessful");
            }
            
            educationPageObj.CreateEducationRecord(driver, collegeUniversityName, countryOfCollegeUniversity, title, degree, yearOfGraduation);
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            if (popupAlert.Text == "This information is already exist.")
            {
                Assert.Pass("Duplicate record not accepted");
            }
            else
            {
                Assert.Fail("Duplicate record accepted");
            }
        }
      
        
       
        [TearDown]
        public void Close()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }


    }
}
