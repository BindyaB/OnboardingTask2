using Mars.Utilities;
using OpenQA.Selenium;

namespace Mars.Pages
{
    public class Login : CommonDriver
    {
        public static IWebElement signInButton => driver.FindElement(By.XPath("//a[@class='item']"));
        public static IWebElement emailAddressTextbox => driver.FindElement(By.XPath("//input[@name='email']"));
        public static IWebElement passwordTextBox => driver.FindElement(By.XPath("//input[@name='password']"));
        public static IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        
        public Login(IWebDriver driver)
        {

            driver.Manage();
            // driver.Manage().Window.Maximize();
            //launch local host 5000

            driver.Navigate().GoToUrl("http://localhost:5000");
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@class='item']", 5);
            
            signInButton.Click();
            emailAddressTextbox.SendKeys("bbindya@gmail.com");
            passwordTextBox.SendKeys("binda581214");
            loginButton.Click();

        }

        
    }
}
