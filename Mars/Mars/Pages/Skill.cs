using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Mars.Pages
{
    public class Skill : CommonDriver
    {
        public static IWebElement skillsTab => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public static IWebElement skillsAddNewButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public static IWebElement addNewSkillsTextBox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement newSkillLevelDropdownMenu => driver.FindElement(By.XPath("//select[@name='level']"));
        public static IWebElement addNewSkillButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public static IWebElement addedNewSkill => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public static IWebElement editSkillWriteIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        public static IWebElement skillUpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public static IWebElement editedSkill => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public static IWebElement deleteSkillButton => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));

        public void GoToSkillTab()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);
            skillsTab.Click();
        }

        public void AddSkill(string skill, string level)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@class='ui teal button']", 5);
            skillsAddNewButton.Click();
            addNewSkillsTextBox.Click();
            addNewSkillsTextBox.SendKeys(skill);
            newSkillLevelDropdownMenu.Click();
            SelectElement oSelect = new SelectElement(newSkillLevelDropdownMenu);
            oSelect.SelectByText(level);
            addNewSkillButton.Click();

        }

        public string GetaddedSkill(string skill)
        {
            Thread.Sleep(5000);
            return addedNewSkill.Text;

        }

        public void EditSkill(string skill, string level)
        {
            editSkillWriteIcon.Click();
            addNewSkillsTextBox.Click();
            addNewSkillsTextBox.Clear();    
            addNewSkillsTextBox.SendKeys(skill);
            newSkillLevelDropdownMenu.Click();
            SelectElement oSelect = new SelectElement(newSkillLevelDropdownMenu);
            oSelect.SelectByText(level);
            skillUpdateButton.Click();
        }

        public string GetEditedSkill(string skill)
        {
            Thread.Sleep(3000);
            return editedSkill.Text;

        }

        public void DeleteSkill(string skill)
        {
            deleteSkillButton.Click();
        }


        public string GetDeletedSkill(string skill)
        {
            Thread.Sleep(5000);
            return editedSkill.Text;
        }

    }
}