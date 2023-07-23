using Automation_Testing.Class_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Testing.Test_Data
{
    [TestFixture, Order(3)]
    class AddToCart_TestData
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
        public void Add_Cart()
        {
            Login log = new Login();
            PageFactory.InitElements(driver, log);
            log.Login_Info("standard_user", "secret_sauce");

            AddToCart cart = new AddToCart(driver);
            cart.Cart();
            cart.Check_Info("John","Roy","099112");
            cart.Logout();

            Assert.Pass("Test Passed");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
