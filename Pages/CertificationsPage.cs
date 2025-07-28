using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class CertificationsPage
    {
        public void CreateCertificationRecord(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            IWebElement certificationOrAwardTextbox = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            certificationOrAwardTextbox.Click();
            certificationOrAwardTextbox.SendKeys("");

            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//input[@name='certificationFrom']"));
            certifiedFromTextbox.Click();
            certifiedFromTextbox.SendKeys("");

            IWebElement yearDropdownButton = driver.FindElement(By.XPath(""));
            yearDropdownButton.Click();
            yearDropdownButton.SendKeys("");

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();

            IWebElement cancelButton = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            cancelButton.Click();




        }
        public void EditCertificationRecord(IWebDriver driver)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            editButton.Click();







        }
    }
}
