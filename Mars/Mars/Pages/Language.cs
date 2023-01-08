using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Language: CommonDriver
    {
        public static IWebElement langTab => driver.FindElement(By.XPath("//a[@class='item active']"));
        public static IWebElement newLangButton => driver.FindElement(By.XPath("//div[@class='ui teal button ']"));
        public static IWebElement addLangButton => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement chooseLeveldropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        public static IWebElement newLangAddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public static IWebElement newLanguage => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public static IWebElement editLangIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        public static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public static IWebElement editedLanguage  => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        public static IWebElement deleteLangButton => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
        
        public void GoToLanguageTab(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@class='item active']", 10);
            langTab.Click();
        }

        public void AddLanguage(IWebDriver driver, string language, string level)
        {
            newLangButton.Click();
            addLangButton.Click();
            addLangButton.SendKeys(language);
            chooseLeveldropdown.Click();
            SelectElement oSelect = new SelectElement(chooseLeveldropdown);
            oSelect.SelectByText(level);
            newLangAddButton.Click();
        }

        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(5000);
            return newLanguage.Text;
        }

        public void EditLanguage(IWebDriver driver, string language, string level)
        {
            editLangIcon.Click();
            addLangButton.Click();
            addLangButton.Clear();
            addLangButton.SendKeys(language);
            chooseLeveldropdown.Click();
            SelectElement oSelect = new SelectElement(chooseLeveldropdown);
            oSelect.SelectByText(level);
            updateButton.Click();
        }

        public string GetEditedLanguage(IWebDriver driver, string language)
        {
            Thread.Sleep(5000);
            return editedLanguage.Text;
        }

        public void DeleteLanguage(IWebDriver driver)
        {
            deleteLangButton.Click();
        }

        public string GetDeletedLang(IWebDriver driver, string language)
        {

            Thread.Sleep(5000);
            return editedLanguage.Text;

        }
    }
}
