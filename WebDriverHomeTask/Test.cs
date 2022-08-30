using NUnit.Framework;
using WebDriverHomeTask.Base;
using WebDriverHomeTask.Pages;

namespace WebDriverHomeTask.Test
{
    [TestFixture]
    public class Test : TestBase
    {
        [Test]
        public void TabShouldContainsAnImageText()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.EnterTextToSearchField("image");
            Assert.That(mainPage.GetTitle().Contains("image"));
            Assert.That(driver.PageSource.Contains("jpeg"));
        }
    }
}