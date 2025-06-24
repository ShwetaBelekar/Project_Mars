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
        [Then("I remove the existing skill record i should see success message")]
        public void ThenIRemoveTheExistingSkillRecordIShouldSeeSuccessMessage()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkillRecord(driver);
           
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


        [When("I create {string} and {string} record")]
        public void WhenICreateAndRecord(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillLevelRecord(driver, skill, level);
        }
        [Then("the record for {string} and {string} should be created successfully")]
        public void ThenTheRecordForAndShouldBeCreatedSuccessfully(string skill, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            if (newSkill.Text == skill && newLevel.Text == level)
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
