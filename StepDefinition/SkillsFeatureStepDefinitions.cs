using System;
using System.Reflection.Emit;
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
   
    public sealed class SkillsFeatureStepDefinitions 
    {
        private IWebDriver driver;

        public SkillsFeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given("I logged into Project Mars successfully for Skill management")]
        public void GivenILoggedIntoProjectMarsSuccessfullyForSkillManagement()
        {
            //driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            loginPageObj.VerifyUserInHomePage(driver);
        }

        [When("I navigate to Skill")]
        public void WhenINavigateToSkill()
        {
            HomeToSkillsPage homeToSkillsPageObj = new HomeToSkillsPage();
            homeToSkillsPageObj.NavigateToSkills(driver);
        }
       
        [When("I create a Skill record")]
        public void WhenICreateASkillRecord()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillRecord(driver);
        }


        [Then("the record should be created successfully for Skill")]
        public void ThenTheRecordShouldBeCreatedSuccessfullyForSkill()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string newSkill = skillsPageObj.GetSkill(driver);
            string newSkillLevel = skillsPageObj.GetSkillLevel(driver);
            Assert.That(newSkill == "Singing", "Actual Skill and Expected Skill do not match.");
            Assert.That(newSkillLevel == "Beginner", "Actual Skilllevel and expected skilllevel do not match.");
        }
        [When("I update the level on an existing skill record")]
        public void WhenIUpdateTheLevelOnAnExistingSkillRecord()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkillRecord(driver);
        }

        [Then("the  skill record should have the updated level")]
        public void ThenTheSkillRecordShouldHaveTheUpdatedLevel()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string editedSkillLevel = skillsPageObj.GetEditedSkillLevel(driver);
            Assert.That(editedSkillLevel == "Intermediate", "Expected edited skill level and actual edited skill level do not match.");
        }

        [When("I deleted the existing skill record")]
        public void WhenIDeletedTheExistingSkillRecord()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkillRecord(driver);
        }

        [Then("i should see a message that record deleted successfully")]
        public void ThenIShouldSeeAMessageThatRecordDeletedSuccessfully()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 2);
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']"));
            if (popupAlert.Text == "Singing has been deleted")
            {
                Assert.Pass("Record Deleted Succesfully");
            }
            else
            {
                Assert.Fail("Record not deleted");
            }
        }

        [When("I create blank {string} and valid {string}")]
        public void WhenICreateBlankAndValid(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillLevelRecord(driver, skill, level);
        }

        [Then("I should see error message for the blank {string} record")]
        public void ThenIShouldSeeErrorMessageForTheBlankRecord(string skill)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string popupAlert = skillsPageObj.BlankSkill(driver);
            if (popupAlert == "Please enter skill and experience level")
            {
                Assert.Pass("Blank skill record not accepted");
            }
            else
            {
                Assert.Fail("Blank skill record accepted");
            }
        }

        [When("I create valid {string} and blank {string}")]
        public void WhenICreateValidAndBlank(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillLevelRecord(driver, skill, level);
        }

        [Then("I should see error message for the blank {string}")]
        public void ThenIShouldSeeErrorMessageForTheBlank(string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string popupAlert = skillsPageObj.BlankLevel(driver);
            if (popupAlert == "Please enter skill and experience level")
            {
               Assert.Pass("Blank level record not accepted");
            }
            else
            {
               Assert.Fail("Blank level record accepted");
            }


        }

        [When("I create invalid {string} and valid {string} record")]
        public void WhenICreateInvalidAndValidRecord(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillLevelRecord(driver, skill, level);
        }

        [Then("if the system accepts invalid {string} and valid {string} record then there is error in the system")]
        public void ThenIfTheSystemAcceptsInvalidAndValidRecordThenThereIsErrorInTheSystem(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (newSkill.Text == skill)
            {
                Assert.Pass("Error in the system");
            }
            else
            {
                Assert.Fail("No Error in the system");
            }


        }


    }
}
