using Automation_Testing.Class_Files;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_Testing
{
    [TestFixture, Order(1)]
    class Login_TestData
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ("https://www.saucedemo.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [Test]
        public void Login_Access()
        {
            Login log = new Login();
            PageFactory.InitElements(driver, log);
            log.Login_Info("standard_user", "secret_sauce");
            Assert.Pass("Test Passed");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}