using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnupportal2025.Utilities;

namespace Project_Mars.Pages
{
    public class SkillsPage
    {
        public void CreateSkillRecord(IWebDriver driver, string Skill, string Level)
        {
            IWebElement aaddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            aaddNewButton.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.SendKeys(Skill);

            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseSkillLevelDropdown.SendKeys(Level);
            Thread.Sleep(2000);
           

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

        public void EditSkillRecord(IWebDriver driver, string NewSkill, string NewLevel)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.Clear();
            addSkillTextbox.SendKeys(NewSkill);

            IWebElement chooseeSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseeSkillLevelDropdown.SendKeys(NewLevel);

           

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
        public string GetEditedSkill(IWebDriver driver)
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }
        public string GetEditedSkillLevel(IWebDriver driver)
        {
            IWebElement editedSkilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedSkilllevel.Text;
        }

        public void DeleteSkillRecord(IWebDriver driver)
        {
            
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            //Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 2);
            //IWebElement popupAlert = driver.FindElement(By.XPath("//div[contains(@class, 'ns-box') and contains(@class, 'ns-growl') and contains(@class, 'ns-type-success')]"));
            //if (popupAlert.Text == "Singing has been deleted")
            //{
            //    Assert.Pass("Record Deleted Succesfully");
            //}
            //else
            //{
            //    Assert.Fail("Record not deleted");
            //}

        }

        public void CreateSkillLevelRecord(IWebDriver driver, string skill, string level)
        {
            IWebElement aaddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            aaddNewButton.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.SendKeys(skill);

            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseSkillLevelDropdown.SendKeys(level);
            Thread.Sleep(2000);


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

        public string BlankSkill(IWebDriver driver)
        {
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            return popupAlert.Text;
        }

        public string BlankLevel(IWebDriver driver)
        {
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            return popupAlert.Text;
        }
        public void CreateDuplicateSkillRecord(IWebDriver driver, string DuplicateSkill, string DuplicateLevel)
        {
            IWebElement aaddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            aaddNewButton.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.SendKeys(DuplicateSkill);

            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseSkillLevelDropdown.SendKeys(DuplicateLevel);
            Thread.Sleep(2000);


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
    }
}
