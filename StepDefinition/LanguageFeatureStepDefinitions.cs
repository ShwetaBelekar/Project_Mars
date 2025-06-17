using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
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
        [When("I create duplicate record for {string} and {string}")]
        public void WhenICreateDuplicateRecordForAnd(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateDuplicateLanguageLevelRecord(driver, Language, Level);
        }
        [Then("I should see error message for duplicate {string} and {string}")]
        public void ThenIShouldSeeErrorMessageForDuplicateAnd(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();

            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            
            if (popupAlert.Text == "This language is already exist in your language list")
            {
                Assert.Pass("Duplicate record not accepted");
            }
            else
            {
                Assert.Fail("Duplicate record is accepted");
            }
        }

    
        [When("I create blank {string} and valid {string} record")]
        public void WhenICreateBlankAndValidRecord(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateBlankLanguageRecord(driver, Language, Level);
        }

        [Then("I should see error message for blank {string} name")]
        public void ThenIShouldSeeErrorMessageForBlankName(string Language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string popupAlert = languagePageObj.BlankLanguage(driver);
            if (popupAlert == "Please enter language and level")
            {
                Assert.Pass("Blank language record not accepted");
            }
            else
            {
                Assert.Fail("Blank language record is accepted");
            }


        }

        [When("I create valid {string} and blank {string} record")]
        public void WhenICreateValidAndBlankRecord(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateBlankLevelRecord(driver, Language, Level);
        }

        [Then("I should see error message for blank {string}")]
        public void ThenIShouldSeeErrorMessageForBlank(string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string popupAlert = languagePageObj.BlankLevel(driver);
            if (popupAlert == "Please enter language and level")
            {
                Assert.Pass("Blank level record not accepted");
            }
            else
            {
                Assert.Fail("Blank level record is accepted");
            }
        }
        
        [When("I edit existing {string} and {string} record")]
        public void WhenIEditExistingAndRecord(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguageRecord(driver, Language, Level);
        }

        [Then("the record for {string} and {string} should be updated successfully")]
        public void ThenTheRecordForAndShouldBeUpdatedSuccessfully(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string editedLanguage = languagePageObj.GetEditedLanguage(driver);
            string editedLevel = languagePageObj.GetEditedLevel(driver);
            Assert.That(editedLanguage == Language, "Expected edited language and actual edited language do not match");
            Assert.That(editedLevel == Level, "Expected edited level and actual edited level do not match");
        }



    }
}
