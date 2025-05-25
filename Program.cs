using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars.Pages;


public class Program 
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        loginPageObj.VerifyUserInHomePage(driver);

        HomeToLanguagePage homeToLanguagePageObj = new HomeToLanguagePage();
        homeToLanguagePageObj.NavigateToLanguage(driver);

        LanguagePage languagePageObj = new LanguagePage();
        languagePageObj.CreateLanguageRecord(driver);

        languagePageObj.EditLanguageRecord(driver);
        
        languagePageObj.DeleteLanguageRecord(driver);

        HomeToSkillsPage homeToSkillsPageObj = new HomeToSkillsPage();
        homeToSkillsPageObj.NavigateToSkills(driver);

        SkillsPage skillsPageObj = new SkillsPage();
        skillsPageObj.CreateSkillRecord(driver);

        skillsPageObj.EditSkillRecord(driver);

        skillsPageObj.DeleteSkillRecord(driver);

    }
}