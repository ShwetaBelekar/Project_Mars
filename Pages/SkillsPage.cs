using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class SkillsPage
    {
        public void CreateSkillRecord(IWebDriver driver)
        {
            IWebElement aaddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            aaddNewButton.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.SendKeys("Singing");

            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseSkillLevelDropdown.Click();
            Thread.Sleep(2000);
            IWebElement beginnerOption = driver.FindElement(By.XPath("//option[@value='Beginner']"));
            beginnerOption.Click();

            IWebElement adddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            adddButton.Click();
            Thread.Sleep(2000);

            //IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            //if (newSkill.Text == "Singing")
            //{
            //    Assert.Pass("Singing skill is created successfully!");
            //}
            //else
            //{
            //    Assert.Fail("Singing skill is not created successfully!");
            //}

        }

        public string GetSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        }

        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement newSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newSkillLevel.Text;
        }

        public void EditSkillRecord(IWebDriver driver)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[10]/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            IWebElement chooseeSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseeSkillLevelDropdown.Click();

            IWebElement intermediateOption = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            intermediateOption.Click();

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

            //IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            //if (newLevel.Text == "Intermediate")
            //{
            //    Assert.Pass("Intermediate is updated!");
            //}
            //else
            //{
            //    Assert.Fail("Intermediate is not updated!");
            //}

        }

        public string GetEditedSkillLevel(IWebDriver driver)
        {
            IWebElement editedSkilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedSkilllevel.Text;
        }

        public void DeleteSkillRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[10]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            Thread.Sleep(5000);

            //IWebElement skills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            //if (skills.Text == "Singing")
            //{
            //    Assert.Pass("Singing is present!");
            //}
            //else
            //{
            //    Assert.Fail("Singing is not present!");
            //}

        }
        public string GetDeletedSkill(IWebDriver driver)
        {
            IWebElement deletedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedSkill.Text;
        }
    }
}
