using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Reqnroll;
using Reqnroll.BoDi;
using SeleniumExtras.WaitHelpers;

namespace Project_Mars.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
           IWebDriver driver = new ChromeDriver();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }


        [AfterScenario()]
        public void CleanUp()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }

        }
        [BeforeFeature()]
        public static void BeforeFeature() 
        {
            //IWebDriver driver = new ChromeDriver();

            
        }
        [AfterFeature()]
        public static void AfterFeature(FeatureContext featureContext)
        {
            IWebDriver driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);


            if (featureContext.FeatureInfo.Tags.Contains("language"))
            {
                try
                {
                    
                    HomeToLanguagePage homeToLanguagePageObj = new HomeToLanguagePage();
                    homeToLanguagePageObj.NavigateToLanguage(driver);
                    
                    // Delete languages logic here
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                    for (int i = deleteButtons.Count - 1; i >= 0; i--)
                    {
                        deleteButtons[i].Click();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during cleanup: {ex.Message}");
                }
                finally
                {
                    driver.Quit();
                }
            }
            else if (featureContext.FeatureInfo.Tags.Contains("skill"))
            {
                try
                {
                   
                    HomeToSkillsPage homeToSkillsPageObj = new HomeToSkillsPage();
                    homeToSkillsPageObj.NavigateToSkills(driver);

                    // Delete languages logic here
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                    for (int i = deleteButtons.Count - 1; i >= 0; i--)
                    {
                        deleteButtons[i].Click();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error during cleanup: {ex.Message}");
                }
                finally
                {
                    driver.Quit();
                }

            }
            else if (featureContext.FeatureInfo.Tags.Contains("Signin"))
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
        


    }

}