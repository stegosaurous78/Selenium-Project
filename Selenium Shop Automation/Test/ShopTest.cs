using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumhopAutomation.Pages;
using SeleniumShopAutomation.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumShopAutomation.Tests
{
    public class ShopTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private CartPage cartPage;
        private CheckoutPage checkoutPage;
        

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            cartPage = new CartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            //confirmationPage = new ConfirmationPage(driver);
        }

        [Test]
        public void ShopWorkflow()
        {
            loginPage.Login("standard_user", "secret_sauce");
            homePage.AddFirstProductToCart();
            homePage.GoToCart();
            cartPage.ProceedToCheckout();
            checkoutPage.FillCheckoutInfo("John", "Doe", "123");

            //string confirmationText = confirmationPage.GetConfirmationText();
            //Assert.IsTrue(confirmationText.Contains("Thank you"), "Order was not completed");

            //confirmationPage.Logout();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
