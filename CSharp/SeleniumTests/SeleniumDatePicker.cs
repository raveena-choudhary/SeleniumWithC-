using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumTests
{
    public class DatePicker
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void TestDatePicker()
        {
            _driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            _driver.Manage().Window.Maximize();

            Actions action = new Actions(_driver);
            action.SendKeys(Keys.Escape).Perform();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            _driver.FindElement(By.XPath("//input[@id='fromCity']")).SendKeys("Delhi");
            _driver.FindElement(By.XPath("//input[@id='toCity']")).SendKeys("Mumbai");
            _driver.FindElement(By.XPath("//span[text()='Departure']")).Click();
            _driver.FindElement(By.XPath("//div[contains(@class,'DayPicker-Day DayPicker-Day--selected')]")).Click();
            _driver.FindElement(By.XPath("//div[contains(@aria-label,'May 14')]")).Click();
            _driver.FindElement(By.XPath("//div[@class ='fareCardItem '][2]")).Click();
            _driver.FindElement(By.XPath("//a[text()='Search']")).Click();

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}