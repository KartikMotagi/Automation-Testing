using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Testing.Class_Files
{
    public class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@id='react-burger-menu-btn']")] IWebElement LeftCornerButton;

        [FindsBy(How = How.XPath, Using = "//button[@id='react-burger-cross-btn']")] IWebElement CancelButton;

        [FindsBy(How = How.XPath, Using = "//select[@class='product_sort_container']")] IWebElement Filter;

        [FindsBy(How = How.XPath, Using = "//div[@class='inventory_item_name']")] IWebElement SelectItem;

        [FindsBy(How = How.XPath, Using = "//button[@id='back-to-products']")] IWebElement BackProduct;

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-500)");
        }
        public void Home()
        {
            LeftCornerButton.Click();
            Thread.Sleep(3000);
            CancelButton.Click();

            SelectElement select = new SelectElement(Filter);
            select.SelectByValue("za");
            Thread.Sleep(3000);

            Scroll();

            SelectElement select1 = new SelectElement(Filter);
            select.SelectByValue("lohi");

            Scroll();

            SelectElement select2 = new SelectElement(Filter);
            select2.SelectByValue("hilo");

            Scroll();
        }

        public void Item()
        {
            SelectItem.Click();
            Scroll();

            BackProduct.Click();
        }

    }
}
