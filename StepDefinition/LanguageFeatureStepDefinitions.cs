using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using Reqnroll;
using Turnupportal2025.Utilities;

namespace Project_Mars.StepDefinition
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        [Given("I login to Project Mars")]
        public void GivenILoginToProjectMars()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            loginPageObj.VerifyUserInHomePage(driver);
        }

        [When("I navigate to language")]
        public void WhenINavigateToLanguage()
        {
            HomeToLanguagePage homeToLanguagePageObj = new HomeToLanguagePage();
            homeToLanguagePageObj.NavigateToLanguage(driver);
        }

        [When("I create valid {string} and valid {string} record")]
        public void WhenICreateValidAndValidRecord(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguageRecord(driver, Language, Level);
        }
        [Then("the record for valid {string} and {string} should be created successfully")]
        public void ThenTheRecordForValidAndShouldBeCreatedSuccessfully(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if (newLanguage.Text == Language && newLevel.Text == Level)
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
