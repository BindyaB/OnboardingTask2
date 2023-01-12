using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Mars.Pages
{
    public class Education:CommonDriver
    {
        public static IWebElement educationTab => driver.FindElement(By.XPath("//a[@data-tab='third']"));
        public static IWebElement addNewEducationbutton => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        public static IWebElement universityName=> driver.FindElement(By.XPath("//input[@name='instituteName']"));
        public static IWebElement countryOfUniversity => driver.FindElement(By.XPath("//select[@name='country']"));
        public static IWebElement eduTitle => driver.FindElement(By.XPath("//select[@name='title']"));
        public static IWebElement eduDegree => driver.FindElement(By.XPath("//input[@name='degree']"));
        public static IWebElement yearOfGraduation => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        public static IWebElement addEducationButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public static IWebElement newEducation => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        public static IWebElement editEducationIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
        public static IWebElement updateEducationButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public static IWebElement deleteEducationIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
        

        public void GoToEducationTab()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='third']", 10);
            educationTab.Click();
        }

        public void AddEducation(string collegeName, string countryOfCollege, string title, string degree, string year )
        {
            addNewEducationbutton.Click();
            universityName.Click();
            universityName.SendKeys(collegeName);
            countryOfUniversity.Click();
            SelectElement oSelect = new SelectElement(countryOfUniversity);
            oSelect.SelectByText(countryOfCollege);
            eduTitle.Click();
            SelectElement selectTitle = new SelectElement(eduTitle);
            selectTitle.SelectByText(title);
            eduTitle.Click();
            eduDegree.SendKeys(degree);
            yearOfGraduation.Click();
            SelectElement selectYear = new SelectElement(yearOfGraduation);
            selectYear.SelectByValue(year);
            addEducationButton.Click();

        }

        public string GetEducation()
        {
            Thread.Sleep(5000);
            return newEducation.Text;
        }
        public void EditEducation(string collegeName, string countryOfCollege)
        {
            editEducationIcon.Click();
            universityName.Click();
            universityName.Clear();
            universityName.SendKeys(collegeName);
            countryOfUniversity.Click();
            SelectElement oSelect = new SelectElement(countryOfUniversity);
            oSelect.SelectByText(countryOfCollege);
            updateEducationButton.Click();

        }
        public string GetEditedEducation()
        {
            Thread.Sleep(5000);
            return newEducation.Text;
        }
        public void DeleteEducation(string collegeName)
        {
            deleteEducationIcon.Click();
        }

        public string GetDeletedEducation()
        {
            Thread.Sleep(5000);
            return newEducation.Text;
        }
    }
}
