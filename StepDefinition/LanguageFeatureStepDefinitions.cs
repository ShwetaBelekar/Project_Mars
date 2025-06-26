using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Log;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using Reqnroll;
using SeleniumExtras.WaitHelpers;
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
        [When("I remove the existing language and level record")]
        public void WhenIRemoveTheExistingLanguageAndLevelRecord()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguageRecord(driver);
        }

        [Then("the record should not be present")]
        public void ThenTheRecordShouldNotBePresent()
        {
            LanguagePage languagePageObj = new LanguagePage();

            IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            
            if (language.Text == "English")
            {
                Assert.Pass("English is not present");
            }
            else
            {
                Assert.Fail("English is Present");
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

        [When("I create invalid {string} and valid {string}")]
        public void WhenICreateInvalidAndValid(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateInvalidLanguageRecord(driver, Language, Level);
        }

        [Then("if the system accepts invalid {string} and valid {string} then there is error in the system")]
        public void ThenIfTheSystemAcceptsInvalidAndValidThenThereIsErrorInTheSystem(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (newLanguage.Text == Language)
            {
                Assert.Pass("Error in the system");
            }
            else
            {
                Assert.Fail("No Error in the system");
            }

        }


        
        
        [When("I update {string} and {string} with new {string} and {string}")]
        public void WhenIUpdateAndWithNewAnd(string OldLanguage, string OldLevel, string NewLanguage, string NewLevel)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.OldLanguageRecord(driver, OldLanguage, OldLevel);
            languagePageObj.NewLanguageRecord(driver, NewLanguage, NewLevel);
        }

        [Then("the {string} and {string} should be updated successfully")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string NewLanguage, string NewLevel)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string editedLanguage = languagePageObj.NewEditedLanguage(driver);
            string editedLevel = languagePageObj.NewEditedLevel(driver);
            Assert.That(editedLanguage == NewLanguage, "Expected edited language and actual edited language do not match");
            Assert.That(editedLevel == NewLevel, "Expected edited level and actual edited level do not match");
        }

        [When("i create {string} and {string}")]
        public void WhenICreateAnd(string Language, string Level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguageRecord(driver, Language, Level);
        }

        [Then("i see {string}")]
        public void ThenISee(string ExpectedMessage)
        {

        }






        


























    }
}
