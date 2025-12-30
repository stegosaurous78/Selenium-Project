using OpenQA.Selenium;

namespace SeleniumhopAutomation.Pages
{
    public class CartPage
    {
        private IWebDriver driver;
        public CartPage(IWebDriver driver) => this.driver = driver;

        private IWebElement CheckoutButton => driver.FindElement(By.XPath("//button[@id='checkout']"));

        public void ProceedToCheckout()
        {
            CheckoutButton.Click();
            Thread.Sleep(3000);
        }
    }
}
