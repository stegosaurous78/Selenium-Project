using OpenQA.Selenium;

namespace SeleniumShopAutomation.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;
        public CheckoutPage(IWebDriver driver) => this.driver = driver;

        private IWebElement FirstName => driver.FindElement(By.XPath("//input[@id='first-name']"));
        private IWebElement LastName => driver.FindElement(By.XPath("//input[@id='last-name']"));
        private IWebElement PostalCode => driver.FindElement(By.XPath("//input[@id='postal-code']"));
        private IWebElement ContinueButton => driver.FindElement(By.XPath("//input[@id='continue']"));
        private IWebElement FinishButton => driver.FindElement(By.XPath("//button[@id='finish']"));
        private IWebElement BackToHomeButton => driver.FindElement(By.XPath("//button[@id='back-to-products']"));
        private IWebElement MenuButton => driver.FindElement(By.XPath("//button[@id='react-burger-menu-btn']"));
        public void FillCheckoutInfo(string fname, string lname, string code)
        {
            FirstName.SendKeys(fname);
            LastName.SendKeys(lname);
            PostalCode.SendKeys(code);
            ContinueButton.Click();
            Thread.Sleep(3000);
            FinishButton.Click();
            Thread.Sleep(3000);
            BackToHomeButton.Click();
            Thread.Sleep(3000);
            MenuButton.Click();
            Thread.Sleep(3000);
        }
    }
}
