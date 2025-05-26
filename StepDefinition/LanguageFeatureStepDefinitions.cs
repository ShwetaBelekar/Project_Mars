using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using Reqnroll;

namespace Project_Mars.StepDefinition
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        [Given("I logged into Project Mars successfully")]
        public void GivenILoggedIntoProjectMarsSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            loginPageObj.VerifyUserInHomePage(driver);

        }

        [When("I navigate to Language")]
        public void WhenINavigateToLanguage()
        {
            HomeToLanguagePage homeToLanguagePageObj = new HomeToLanguagePage();
            homeToLanguagePageObj.NavigateToLanguage(driver);
        }

        [When("I create a language record")]
        public void WhenICreateALanguageRecord()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguageRecord(driver);

        }

        [Then("the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            LanguagePage languagePageObj = new LanguagePage();

            string newLanguage = languagePageObj.GetLanguage(driver);
            string newLevel = languagePageObj.GetLevel(driver);
            Assert.That(newLanguage == "English", "Actual Language and expected language do not match");
            Assert.That(newLevel == "Basic", "Actual level and expected level do not match");
        }
    }
}
