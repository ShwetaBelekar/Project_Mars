using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Project_Mars.Utilities;
using Reqnroll;

namespace Project_Mars.StepDefinition
{
    [Binding]
    public class SigninFeatureStepDefinitions : CommonDriver
    {
        [Given("I get into the homepage")]
        public void GivenIGetIntoTheHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5003/Home");
            driver.Manage().Window.Maximize();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            SigninPage signinPageObj = new SigninPage();
            signinPageObj.ValidSigninAction();
        }

        [Then("I should be able to Signin successfully")]
        public void ThenIShouldBeAbleToSigninSuccessfully()
        {
            Thread.Sleep(2000);
            IWebElement hitony = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

            if (hitony.Text == "Hi Tony")
            {
                Console.WriteLine("User has logged in successfully. Test Passed!");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test Failed!");
            }

        }

        [When("I enter blank {string} and valid {string}")]
        public void WhenIEnterBlankAndValid(string email, string password)
        {
            SigninPage signinPageObj = new SigninPage();
            signinPageObj.InValidSigninAction(email, password);
            Thread.Sleep(2000);
        }

        [Then("I should see an error message for blank {string}")]
        public void ThenIShouldSeeAnErrorMessageForBlank(string email)
        {
            IWebElement EmailField = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));

            if (EmailField.Text == "Please enter a valid email address")
            {
                Assert.Pass("Error message displayed for blank email");
            }
            else
            {
                Assert.Fail("No error message displayed for blank email field");
            }
        }

        [When("I enter valid {string} and blank {string}")]
        public void WhenIEnterValidAndBlank(string email, string password)
        {
            SigninPage signinPageObj = new SigninPage();
            signinPageObj.InValidSigninAction(email, password);
        }

        [Then("I should see an error message for {string}")]
        public void ThenIShouldSeeAnErrorMessageFor(string password)
        {
            IWebElement PasswordField = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div"));
            if (PasswordField.Text == "Password must be at least 6 characters")
            {
                Assert.Pass("Error message displayed for blank password");
            }
            else
            {
                Assert.Fail("No error message displayed for blank password field");
            }
        }
    }
}
