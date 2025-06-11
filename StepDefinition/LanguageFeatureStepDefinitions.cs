using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
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
        [When("I create multiple {string} and {string} in language record")]
        public void WhenICreateMultipleAndInLanguageRecord(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguageRecord(driver, language, level);
        }

        [Then("the multiple {string} and {string} record should be created successfully")]
        public void ThenTheMultipleAndRecordShouldBeCreatedSuccessfully(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
           
            
        }

        [When("I update the {string} and {string} on an existing language record")]

        public void WhenIUpdateTheAndOnAnExistingLanguageRecord(string language, string level)

        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguageRecord(driver, language, level);

        }


        [Then("the record should have the updated {string} and {string}")]

        public void ThenTheRecordShouldHaveTheUpdatedAnd(string language, string level)

        {
            LanguagePage languagePageObj = new LanguagePage();
            string editedLanguage = languagePageObj.GetLanguage(driver);
            string editedLevel = languagePageObj.GetLevel(driver);
            Assert.That(editedLanguage == language, "Expected edited langugage and actual edited language do not match.");
            Assert.That(editedLevel == level, "Expected edited level and actual edited level do not match.");

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
    

