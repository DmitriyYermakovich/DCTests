using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RegistrationTest()
        {
            var name = "Test user";
            var email = "testemail1@sdventures.com";
            var password = "654321";

            IWebDriver Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl("https://www.dating.com");
            Browser.Manage().Window.Maximize();
            Browser.FindElement(By.CssSelector(".action.default.medium.default.action")).Click();
            Browser.FindElement(By.CssSelector("div.react-footer")).Click();
            Browser.FindElement(By.CssSelector("div.input-container [type='text']")).SendKeys(name);
            Browser.FindElement(By.CssSelector("div.input-container [type='email'].data.has-description")).SendKeys(email);
            Browser.FindElement(By.CssSelector(".input-container [data-reactid='57']")).SendKeys(password);
            Browser.FindElement(By.CssSelector(".action[data-reactid='63']")).Click();
            //Browser.FindElement(By.CssSelector(".gender [value='mal']")).Click();
            //Browser.FindElement(By.CssSelector(".field.group [value='fem']")).Click();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(7));
            Browser.Quit();
        }
        [Test]
        public void AuthorizationTest()
        {

            var email = "dcUMT_1581089986812_test@dating.com";
            var password = "654321";

            IWebDriver Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl("https://www.dating.com");
            Browser.Manage().Window.Maximize();
            Browser.FindElement(By.CssSelector(".action.default.medium.default.action")).Click();
            Browser.FindElement(By.CssSelector(".authorization-form-wrapper [type='email']")).SendKeys(email);
            Browser.FindElement(By.CssSelector(".authorization-form-wrapper [type='password']")).SendKeys(password);
            Browser.FindElement(By.CssSelector("[value='sign-in']")).Click();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(7));
            Browser.Quit();
        }
    }
}