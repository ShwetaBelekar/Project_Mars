using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.BiDi.Modules.Log;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
         

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);

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

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

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
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            driver.Navigate().Refresh();
            Thread.Sleep(5000);

            
        }
        public string GetDeleteLanguageLevelRecord(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]",3);
            IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return language.Text;
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
        
        public void CreateInvalidLanguageRecord(IWebDriver driver, string language, string level)
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

        
        

        public void OldLanguageRecord(IWebDriver driver, string OldLanguage, string OldLevel)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(OldLanguage);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement selectLevel = new SelectElement(chooseLanguageLevelDropDown);
            selectLevel.SelectByText(OldLevel);


            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);

        }
        public void NewLanguageRecord(IWebDriver driver, string NewLanguage, string NewLevel)
        {
            Thread.Sleep(2000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement languageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            languageTextbox.Clear();
            languageTextbox.SendKeys(NewLanguage);

            IWebElement dropDownButton = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectLevel = new SelectElement(dropDownButton);
            selectLevel.SelectByText(NewLevel);

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

        }

        public string NewEditedLanguage(IWebDriver driver)
        {
            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguage.Text;
        }

        public string NewEditedLevel(IWebDriver driver)
        {
            IWebElement editedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedLevel.Text;
        }

        public void CreateLanguageLevelRecord(IWebDriver driver, string language, string level)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement selectLevel = new SelectElement(chooseLanguageLevelDropDown);
            selectLevel.SelectByText(level);


            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(7000);
        }

        public void DuplicateLanguageRecord(IWebDriver driver, string Language, string Level)
        {
           
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys(Language);

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement selectLevel = new SelectElement(chooseLanguageLevelDropDown);
            selectLevel.SelectByText(Level);


            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            
        }

      

            

    }
}
