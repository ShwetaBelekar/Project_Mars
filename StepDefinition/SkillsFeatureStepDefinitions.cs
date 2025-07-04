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

        [When("I create a {string} with {string} record")]
        public void WhenICreateAWithRecord(string Skill, string Level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillRecord(driver, Skill, Level);
        }

        [Then("the record for {string} with {string} should be created successfully")]
        public void ThenTheRecordForWithShouldBeCreatedSuccessfully(string Skill, string Level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string newSkill = skillsPageObj.GetSkill(driver);
            string newSkillLevel = skillsPageObj.GetSkillLevel(driver);
            Assert.That(newSkill == Skill, "Actual Skill and Expected Skill do not match.");
            Assert.That(newSkillLevel == Level, "Actual Skilllevel and expected skilllevel do not match.");
        }

        [When("i see existing {string} and {string} records")]
        public void WhenISeeExistingAndRecords(string Skill, string Level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillRecord(driver, Skill, Level);
        }

        [When("I update the existing skill and level with new {string} and {string}")]
        public void WhenIUpdateTheExistingSkillAndLevelWithNewAnd(string NewSkill, string NewLevel)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkillRecord(driver, NewSkill, NewLevel);
        }

        [Then("the should the {string} and {string} record")]
        public void ThenTheShouldTheAndRecord(string NewSkill, string NewLevel)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string editedSkill = skillsPageObj.GetEditedSkill(driver);
            string editedSkillLevel = skillsPageObj.GetEditedSkillLevel(driver);
            Assert.That(editedSkill == NewSkill, "Expected edited skill and actual edited skill do not match");
            Assert.That(editedSkillLevel == NewLevel, "Expected edited skill level and actual edited skill level do not match.");
        }


        [When("i see {string} and {string}")]
        public void WhenISeeAnd(string Skill, string Level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillRecord(driver, Skill, Level);
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
            if (popupAlert.Text == "Drawing has been deleted")
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

        [When("I create {string} and {string} record successfully")]
        public void WhenICreateAndRecordSuccessfully(string Skill, string Level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkillLevelRecord(driver, Skill, Level);
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (newSkill.Text == "ProblemSolving")
            {
                Console.WriteLine("ProblemSolving is created successfully!");
            }
            else
            {
                Console.WriteLine("ProblemSolving is not created successfully!");


            }
        }
        [When("I create {string} and {string} record")]
        public void WhenICreateAndRecord(string DuplicateSkill, string DuplicateLevel)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateDuplicateSkillRecord(driver, DuplicateSkill, DuplicateLevel);
        }

        [Then("i should see error message for duplicate skill")]
        public void ThenIShouldSeeErrorMessageForDuplicateSkill()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//div[contains(@class, 'ns-box') and contains(@class, 'ns-type-error')]", 1);
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[contains(@class, 'ns-box') and contains(@class, 'ns-type-error')]"));
            if (popupAlert.Text == "This skill is already exist in your skill list.")
            {
                Assert.Pass("Duplicate record not accepted");
            }
            else
            {
                Assert.Fail("Duplicate record accepted");
            }
        }

    }
}
