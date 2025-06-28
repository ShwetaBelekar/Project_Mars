using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;
using Reqnroll;
using Reqnroll.BoDi;

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

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}