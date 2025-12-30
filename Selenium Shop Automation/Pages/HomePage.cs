using OpenQA.Selenium;

namespace SeleniumShopAutomation.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver) => this.driver = driver;

        private IWebElement FirstProduct => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
        private IWebElement CartLink => driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));

        public void AddFirstProductToCart() => FirstProduct.Click();
        public void GoToCart()
        {
            CartLink.Click();
            Thread.Sleep(3000);
        }
    }
}
