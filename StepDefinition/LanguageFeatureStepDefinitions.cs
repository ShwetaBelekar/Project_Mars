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
        [Given("I logged into Project Mars successfully for language management")]
        public void GivenILoggedIntoProjectMarsSuccessfullyForLanguageManagement()
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

        [Then("the record should be created successfully for language")]
        public void ThenTheRecordShouldBeCreatedSuccessfullyForLanguage()
        {
            LanguagePage languagePageObj = new LanguagePage();

            string newLanguage = languagePageObj.GetLanguage(driver);
            string newLevel = languagePageObj.GetLevel(driver);
            Assert.That(newLanguage == "English", "Actual Language and expected language do not match");
            Assert.That(newLevel == "Basic", "Actual level and expected level do not match");
        }

        [When("I update the {string} on an existing language record")]
        public void WhenIUpdateTheOnAnExistingLanguageRecord(string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguageRecord(driver, level);
        }

        [Then("the record should have the updated {string}")]
        public void ThenTheRecordShouldHaveTheUpdated(string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string editedLevel = languagePageObj.GetLevel(driver);
            Assert.That(editedLevel == "Fluent", "Expected Edited level and actual edited level do not match");
        }

        [When("I remove the existing language record")]
        public void WhenIRemoveTheExistingLanguageRecord()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguageRecord(driver);
        }

        [Then("the record should not be present on the language list")]
        public void ThenTheRecordShouldNotBePresentOnTheLanguageList()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string deletedLanguage = languagePageObj.GetLanguage(driver);
            Assert.That(deletedLanguage, Is.Not.EqualTo("English"), "Expected English to be deleted, but it still exists");

        }


    }
}
