using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class LanguagePage
    {
        public void CreateLanguageRecord(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(2000);

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys("English");

            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguageLevelDropDown.Click();
            Thread.Sleep(2000);

            IWebElement basicOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
            basicOption.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            Thread.Sleep(5000);

            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (newLanguage.Text == "English")
            {
                Console.WriteLine("New Language record created Successfully!");
            }
            else
            {
                Console.WriteLine("New Language record has not been created!");
            }

        }

        public void EditLanguageRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement dropDownButton = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            dropDownButton.Click();

            IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            fluentOption.Click();

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();
            Thread.Sleep(2000);

            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if (newLevel.Text == "Fluent")
            {
                Console.WriteLine("Fluent level is updated Successfully!");
            }
            else
            {
                Console.WriteLine("Fluent level is not updated Successfully!");
            }

        }

        public void DeleteLanguageRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]"));
            deleteButton.Click();
            driver.Navigate().Refresh();
            Thread.Sleep(5000);

            IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (language.Text == "English")
            {
                Console.WriteLine("English is present");
            }
            else
            {
                Console.WriteLine("English is not present");
            }
        }
    }
}
