using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class Test
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void TestGoogleSearch()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            _driver.FindElement(By.Name("q")).SendKeys("Selenium");
            _driver.FindElement(By.Name("q")).Submit();
            Assert.That(_driver.Title, Does.Contain("Selenium"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}