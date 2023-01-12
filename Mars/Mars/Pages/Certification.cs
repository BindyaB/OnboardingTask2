using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars.Pages
{
    public class Certification: CommonDriver
    {
            public static IWebElement certificationTab => driver.FindElement(By.XPath("//a[@data-tab='fourth']"));
            public static IWebElement addNewCertificateButton => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            public static IWebElement awardTextbox => driver.FindElement(By.XPath("//input[@name='certificationName']"));
            public static IWebElement certifiedFromTextbox => driver.FindElement(By.XPath("//input[@name='certificationFrom']"));
            public static IWebElement certificationYearDropdown => driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            public static IWebElement addCertificationButton => driver.FindElement(By.XPath("//input[@value='Add']"));
            public static IWebElement editCertificationIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            public static IWebElement updateCertificateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
            public static IWebElement newCertification => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            public static IWebElement deleteCertificationIcon => driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
          
            public void GoToCertification()
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@data-tab='fourth']", 10);
                certificationTab.Click();
            }

            public void AddCertification (string certificate, string certifiedBy, string year)
            {
                addNewCertificateButton.Click();
                awardTextbox.Click();
                awardTextbox.SendKeys(certificate);
                certifiedFromTextbox.Click();
                certifiedFromTextbox.SendKeys(certifiedBy);
                certificationYearDropdown.Click();
                SelectElement oSelect = new SelectElement(certificationYearDropdown);
                oSelect.SelectByText(year);
                addCertificationButton.Click();

            }

            public string GetCertification()
            {
                Thread.Sleep(5000);
                return newCertification.Text;
            }
            public void EditCerification(string certificate, string certifiedBy)
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i", 10);
                editCertificationIcon.Click();
                awardTextbox.Click();
                awardTextbox.Clear();
                awardTextbox.SendKeys(certificate);
                certifiedFromTextbox.Click();
                certifiedFromTextbox.Clear();
                certifiedFromTextbox.SendKeys(certifiedBy);
                updateCertificateButton.Click();

            }
            public string GetEditedCertification()
            {
                Thread.Sleep(5000);
                return newCertification.Text;
            }
            public void DeleteCertification(string certificate)
            {
                deleteCertificationIcon.Click();
            }

            public string GetDeletedCertification()
            {
                Thread.Sleep(5000);
                return newCertification.Text;
            }


        }
}
