using NUnit.Framework;
using OpenQA.Selenium;
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
    [Category("Certification")]

    public class Certification_Tests : BaseTest
    {
        [SetUp]
        public void SetUpSteps()
        {
            //driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginActions(driver);

            loginPageObj.VerifyUserInHomePage(driver);

            HomeToCertificationsPage homeToCertificationsPageObj = new HomeToCertificationsPage();
            homeToCertificationsPageObj.NavigateToCertifications(driver);
        }
        [Test(Description = "Create Valid Certification Record")]
        [TestCase("Test Analyst", "Industry Connect", "2020")]
        [TestCase("Web Developer", "Connect Industry", "2007")]
        [TestCase("Data Analyst", "IT School", "2024")]
        [TestCase("Data Science", "NZ University", "2017")]
        public void CreateValidCertificationRecord(string certificateaward, string certificatefrom, string year)
        {
            CertificationsPage certificationsPageObj = new CertificationsPage();
            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
            IWebElement newcertificateaward = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newcertificatefrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            if (newcertificateaward.Text == certificateaward && newcertificatefrom.Text == certificatefrom && newyear.Text == year)
            {
                Assert.Pass("record created successfully");
            }
            else
            {
                Assert.Fail("record creation unsuccessful");
            }
        }

        [Test(Description = "Check if the system accepts blank field certification record")]
        [TestCase("", "Industry Connect", "2020")]
        [TestCase("Data Analyst", "", "2024")]
        [TestCase("Web Developer", "Connect Industry", "")]
        
        
        public void TryToCreateCertificationRecordWithBlankField(string certificateaward, string certificatefrom, string year)
        {
            CertificationsPage certificationsPageObj = new CertificationsPage();
            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            
            if (popupAlert.Text == "Please enter Certification Name, Certification From and Certification Year")
            {
                Assert.Pass("Blank field record not accepted and Popup message says Please enter Certification Name, Certification From and Certification Year");
            }
            else
            {
                Assert.Fail("Blank field record is accepted and no popup message appears");
            }

        }

        [Test(Description = "Create invalid certification record")]
        [TestCase("1234", "Jungle","2005")]
        [TestCase("ABCDEFGH", "Forest","2006")]
        [TestCase("123@@@@###abcEFG", "Sun","2020")]
        [TestCase("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB", "Moon","2022")]
        [TestCase("@@@@###$$$%%%%^^^", "World","2025")]
        public void CreateInvalidCertificationRecord(string certificateaward, string certificatefrom, string year)
        {
            CertificationsPage certificationsPageObj = new CertificationsPage();
            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
            IWebElement newcertificateaward = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newcertificatefrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
          
            if (newcertificateaward.Text == certificateaward && newcertificatefrom.Text == certificatefrom)
            {
                Assert.Pass("Invalid record accepted error in the system");
            }
            else
            {
                Assert.Fail("Invalid record not accepted no error in the system");
            }
        }
        [Test(Description = "Create Duplicate Certification Record")]
        [TestCase("Web Developer", "IndustryConnect", "2007")]


        public void CreateDuplicateCertificationRecord(string certificateaward, string certificatefrom, string year)

        {
            CertificationsPage certificationsPageObj = new CertificationsPage();
            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
            IWebElement newcertificateaward = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newcertificatefrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            if (newcertificateaward.Text == certificateaward && newcertificatefrom.Text == certificatefrom && newyear.Text == year)
            {
                Console.WriteLine("record created successfully");
            }
            else
            {
                Console.WriteLine("record creation unsuccessful");
            }

            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
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
        [Test(Description = "Edit exisitng certification record")]
        [TestCase("Test Analyst", "Industry Connect", "2020", "Web Developer", "Connect Industry", "2007")]
        [TestCase("Data Analyst", "IT School", "2024", "Data Science", "NZ University", "2017")]
        public void EditExistingCertificationRecord(string certificateaward, string certificatefrom, string year, string newcertificateaward, string newcertificatefrom, string newyear)
        {
            CertificationsPage certificationsPageObj = new CertificationsPage();
            certificationsPageObj.CreateCertificationRecord(driver, certificateaward, certificatefrom, year);
            IWebElement createdcertificateaward = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement createdcertificatefrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement createdyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            if (createdcertificateaward.Text == certificateaward && createdcertificatefrom.Text == certificatefrom && createdyear.Text == year)
            {
                Console.WriteLine("record created successfully");
            }
            else
            {
                Console.WriteLine("record creation unsuccessful");
            }
            
            certificationsPageObj.EditCertificationRecord(driver, newcertificateaward, newcertificatefrom, newyear);
            IWebElement editedcertificateaward = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement editedcertificatefrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement editedyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            if (editedcertificateaward.Text == newcertificateaward &&  editedcertificatefrom.Text == newcertificatefrom && editedyear.Text == newyear)
            {
                Assert.Pass("record edited successfully");
            }
            else
            {
                Assert.Fail("record not edited");
            }
        }
    }
}
