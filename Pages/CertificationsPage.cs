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
        private IWebDriver driver;
        private IWebElement addNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement certificationOrAwardTextbox => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));

        private IWebElement certifiedFromTextbox => driver.FindElement(By.XPath("//input[@name='certificationFrom']"));
        private IWebElement yearDropdownButton => driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));

        private IWebElement cancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));

        private IWebElement editButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));

        private IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));

        private IWebElement deleteButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
        public void CreateCertificationRecord(IWebDriver driver, string certificateaward, string certificatefrom, string year)
        {
            this.driver = driver;
            addNewButton.Click();

            
            certificationOrAwardTextbox.Click();
            certificationOrAwardTextbox.SendKeys(certificateaward); 

            
            certifiedFromTextbox.Click();
            certifiedFromTextbox.SendKeys(certificatefrom);

            
            yearDropdownButton.Click();
            yearDropdownButton.SendKeys(year);

           
            addButton.Click();


            Thread.Sleep(7000);




        }
        public void EditCertificationRecord(IWebDriver driver)
        {
            
            editButton.Click();
            cancelButton.Click();

            updateButton.Click();

        }
        public void DeleteCertificationRecord(IWebDriver driver)
        {
            
            deleteButton.Click();
        }
    }
}
