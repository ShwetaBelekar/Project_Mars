using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        //driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:5003/Home");
        driver.Manage().Window.Maximize();
        Thread.Sleep(3000);

        IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        signinButton.Click();
        Thread.Sleep(2000);

        IWebElement emailAddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        emailAddressTextbox.SendKeys("moneytony@ymail.com");

        IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        passwordTextbox.SendKeys("Tonymoney@2025");

        IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        loginButton.Click();
        Thread.Sleep(3000);

        IWebElement hitony = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

        if (hitony.Text == "Hi Tony")
        {
            Console.WriteLine("User has logged in successfully. Test Passed!");
        }
        else 
        {
            Console.WriteLine("User has not logged in. Test Failed!");
        }

        Thread.Sleep(2000);

        IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
        profileTab.Click();

        //IWebElement languageOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        //languageOption.Click();

        //IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        //addNewButton.Click();
        //Thread.Sleep(2000);

        //IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        //addLanguageTextbox.SendKeys("English");

        //IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        //chooseLanguageLevelDropDown.Click();
        //Thread.Sleep(2000);

        //IWebElement basicOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
        //basicOption.Click();

        //IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
        //addButton.Click();

        //IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

        //if (newLanguage.Text == "English")
        //{
        //    Console.WriteLine("New Language record created Successfully!");
        //}
        //else
        //{
        //    Console.WriteLine("New Language record has not been created!");
        //}

        //Thread.Sleep(2000);

        //IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
        //editButton.Click();

        //IWebElement dropDownButton = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
        //dropDownButton.Click();

        //IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
        //fluentOption.Click();

        //IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
        //updateButton.Click();
        //Thread.Sleep(2000);

        //IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        //if (newLevel.Text == "Fluent")
        //{
        //    Console.WriteLine("Fluent level is updated Successfully!");
        //}
        //else
        //{
        //    Console.WriteLine("Fluent level is not updated Successfully!");
        //}
        //Thread.Sleep(2000);
        //IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]"));
        //deleteButton.Click();
        //driver.Navigate().Refresh();
        //Thread.Sleep(5000);

        //IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

        //if(language.Text == "English")
        //{
        //    Console.WriteLine("English is present");
        //}
        //else
        //{
        //    Console.WriteLine("English is not present");
        //}

        //driver.Quit();

        IWebElement skillsOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        skillsOption.Click();
        Thread.Sleep(2000);

        IWebElement aaddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        aaddNewButton.Click();

        IWebElement addSkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        addSkillTextbox.SendKeys("Singing");

        IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
        chooseSkillLevelDropdown.Click();
        Thread.Sleep(2000);
        IWebElement beginnerOption = driver.FindElement(By.XPath("//option[@value='Beginner']"));
        beginnerOption.Click();

        IWebElement adddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
        adddButton.Click();
        Thread.Sleep(2000);

        IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

        if (newSkill.Text == "Singing")
        {
            Console.WriteLine("Singing skill is created successfully!");
        }
        else
        {
            Console.WriteLine("Singing skill is not created successfully!");
        }

        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[10]/tr/td[3]/span[1]"));
        editButton.Click();
        Thread.Sleep(2000);

        IWebElement chooseeSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
        chooseeSkillLevelDropdown.Click();

        IWebElement intermediateOption = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
        intermediateOption.Click();

        IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
        updateButton.Click();
        Thread.Sleep(2000);

        IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        if (newLevel.Text == "Intermediate")
        {
            Console.WriteLine("Intermediate is updated!");
        }
        else
        {
            Console.WriteLine("Intermediate is not updated!");
        }

        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[10]/tr/td[3]/span[2]/i"));
        deleteButton.Click();
        Thread.Sleep(5000);

        IWebElement skills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

        if(skills.Text == "Singing")
        {
            Console.WriteLine("Singing is present!");
        }
        else
        {
            Console.WriteLine("Singing is not present!");
        }



        







    }
}