using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using Reqnroll;

namespace Project_Mars.StepDefinition
{
    [Binding]
   
    public class SkillsFeatureStepDefinitions : CommonDriver
    {
        
        [Given("I logged into Project Mars successfully for Skill management")]
        public void GivenILoggedIntoProjectMarsSuccessfullyForSkillManagement()
        {
            driver = new ChromeDriver();

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

        [When("I remove the existing skill record")]
        public void WhenIRemoveTheExistingSkillRecord()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkillRecord(driver);
        }

        [Then("the record should not be present on the skill list")]
        public void ThenTheRecordShouldNotBePresentOnTheSkillList()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string deletedSkill = skillsPageObj.GetDeletedSkill(driver);
            Assert.That(deletedSkill, Is.Not.EqualTo("Singing"), "Expected Singing to be deleted, but it still exists");
        }


    }
}
