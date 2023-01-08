using Mars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    //Adding description in the description text box and saving 
    public class Description: CommonDriver
    {
        public static IWebElement writeIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        public static IWebElement descriptionTextbox => driver.FindElement(By.XPath("//textarea[@name='value']"));
        public static IWebElement descSaveButton => driver.FindElement(By.XPath("//button[@type='button']"));
        public static IWebElement descText => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
        public void AddDescription(IWebDriver driver)
        {

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10);
            writeIcon.Click();
            descriptionTextbox.Click(); 
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Hi I am a ballet dancer");
            descSaveButton.Click();
        }

        public string GetDescription(IWebDriver driver)
        {
            WaitHelpers.WaitToExist(driver, "Xpath", "//div/section[2]/div/div/div/div[3]/div/div/div/span", 5);
            return descText.Text;

        }
    }
}
