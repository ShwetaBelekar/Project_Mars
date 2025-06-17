using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnupportal2025.Utilities;

namespace Project_Mars.Pages
{
    public class LanguagePage
    {
        public void CreateLanguageRecord(IWebDriver driver, string language, string level)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement selectLevel = new SelectElement(chooseLanguageLevelDropDown);
            selectLevel.SelectByText(level);
            //chooseLanguageLevelDropDown.Click();
            //Thread.Sleep(2000);

            //IWebElement basicOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
            //basicOption.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);

            //IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            //if (newLanguage.Text == "English")
            //{
            //    Assert.Pass("New Language record created Successfully!");
            //}
            //else
            //{
            //    Assert.Fail("New Language record has not been created!");
            //}

        }

        public string GetLanguage(IWebDriver driver)
        {
           
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text; 
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newLevel.Text;
        }

        public void CreateDuplicateLanguageLevelRecord(IWebDriver driver, string language, string level)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevelDropDown.SendKeys(level);

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);
        }
        public string DuplicateLanguageLevel(IWebDriver driver)
        {
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            return popupAlert.Text;
        }
        

        public void CreateBlankLanguageRecord(IWebDriver driver, string language, string level)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevelDropDown.SendKeys(level);

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(2000);
            
        }
        public string BlankLanguage(IWebDriver driver)
        {
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-error ns-show']"));
            return popupAlert.Text;
        }

        public void CreateBlankLevelRecord(IWebDriver driver, string language, string level)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevelDropDown.SendKeys(level);

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);
        }

        public string BlankLevel(IWebDriver driver)
        {
            IWebElement popupAlert = driver.FindElement(By.XPath("//div[contains(@class, 'ns-') and contains(@class, '-error')]"));
            return popupAlert.Text;
        }
        

        public void EditLanguageRecord(IWebDriver driver, string language, string level)
        {
            Thread.Sleep(2000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement languageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            languageTextbox.Clear();
            languageTextbox.SendKeys(language);

            IWebElement dropDownButton = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectLevel = new SelectElement(dropDownButton);
            selectLevel.SelectByText(level);
            //dropDownButton.Click();
            //Thread.Sleep(5000);

            //IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            //fluentOption.Click();


            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

            //IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            //if (newLevel.Text == "Fluent")
            //{
            //    Assert.Pass("Fluent level is updated Successfully!");
            //}
            //else
            //{
            //    Assert.Fail("Fluent level is not updated Successfully!");
            //}

        }
        public string GetEditedLanguage(IWebDriver driver)
        {
            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            return editedLanguage.Text;        
        }

        public string GetEditedLevel(IWebDriver driver)
        {
            IWebElement editedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
            return editedLevel.Text;
        }


        public void DeleteLanguageRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]"));
            deleteButton.Click();
            driver.Navigate().Refresh();
            Thread.Sleep(5000);

            //IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            //if (language.Text == "English")
            //{
            //    Assert.Pass("English is present");
            //}
            //else
            //{
            //    Assert.Fail("English is not present");
            //}
        }

        public string GetDeletedLanguage(IWebDriver driver)
        {
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedLanguage.Text;
        }
    }
}
