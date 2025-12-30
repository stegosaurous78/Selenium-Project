using OpenQA.Selenium;

namespace SeleniumShopAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Username => driver.FindElement(By.XPath("//input[@id='user-name']"));
        private IWebElement Password => driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@id='login-button']"));

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
            Thread.Sleep(3000);

        }
    }
}
