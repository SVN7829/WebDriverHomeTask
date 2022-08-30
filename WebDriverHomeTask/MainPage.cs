using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebDriverHomeTask.Pages
{
    public class MainPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//input[@title = 'Поиск']")]
        private IWebElement searchField { get; set; }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public MainPage EnterTextToSearchField(string txt)
        {
            searchField.Clear();
            searchField.SendKeys(txt);
            searchField.Submit();
            
            return new MainPage(Driver);
        }

        public string title;
        public string GetTitle()
        {
            return Driver.Title;
        }

    }
}

