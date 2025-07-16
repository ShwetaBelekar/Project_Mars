using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mars.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            //driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void Close() 
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

    }
}
