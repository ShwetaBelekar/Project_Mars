using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    public class HomeToLanguagePage
    {
        public void NavigateToLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileTab.Click();

            IWebElement languageOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageOption.Click();

        }
    }
}
