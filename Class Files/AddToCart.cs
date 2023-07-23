using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Testing.Class_Files
{
    public class AddToCart
    {
        public IWebDriver driver;

        public AddToCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='inventory_item_name']")] IWebElement SelectedItem;

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-backpack")] IWebElement ClickonAddCart;

        [FindsBy(How = How.XPath, Using = "//a[@class='shopping_cart_link']")] IWebElement AddCart;

        [FindsBy(How = How.Id, Using = "checkout")] IWebElement Checkout;

        [FindsBy(How = How.Id, Using = "first-name")] IWebElement FirstName_Checkout;

        [FindsBy(How = How.Id, Using = "last-name")] IWebElement LastName_Checkout;

        [FindsBy(How = How.Id, Using = "postal-code")] IWebElement Postal_Code;

        [FindsBy(How = How.Id, Using = "continue")] IWebElement Continue_Checkout;

        [FindsBy(How = How.Id, Using = "finish")] IWebElement Finish_Checkout;

        [FindsBy(How = How.Id, Using = "back-to-products")] IWebElement BackToHome;

        [FindsBy(How = How.XPath, Using = "//button[@id='react-burger-menu-btn']")] IWebElement LeftCornerButton;

        [FindsBy(How = How.Id, Using = "logout_sidebar_link")] IWebElement Logout_App;

        public void Cart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            SelectedItem.Click();
            ClickonAddCart.Click();
            AddCart.Click();
            Checkout.Click();
        }

        public void Check_Info(String first, String last, String zip)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            FirstName_Checkout.SendKeys(first);
            LastName_Checkout.SendKeys(last);
            Postal_Code.SendKeys(zip);
            Continue_Checkout.Click();
            Thread.Sleep(3000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-500)");

            Finish_Checkout.Click();
            Thread.Sleep(3000);

            BackToHome.Click();
            Thread.Sleep(3000);

        }

        public void Logout()
        {
            LeftCornerButton.Click();
            Logout_App.Click();
            Thread.Sleep(3000);
        }
    }
}
