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
    }
}
