using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions:CommonDriver
    {
        Education educationObj = new Education();

        [When(@"I navigate to the education tab")]
        public void WhenINavigateToTheEducationTab()
        {
            educationObj.GoToEducationTab(); 
        }

        [When(@"I add '([^']*)', '([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenIAdd(string collegeName, string countryOfCollege, string title, string degree, string year)
        {
            educationObj.AddEducation(collegeName, countryOfCollege, title, degree, year);
        }

        [Then(@"I am able to see the '([^']*)' education qualification")]
        public void ThenIAmAbleToSeeTheEducationQualification(string collegeName)
        {
            string newEducation = educationObj.GetEducation();
            Assert.That(newEducation == collegeName, "University/College name not added");
        }

        [When(@"I edit the existing education qualification '([^']*)', '([^']*)'")]
        public void WhenIEditTheExistingEducationQualification(string collegeName, string countryOfCollege)
        {
            educationObj.EditEducation(collegeName, countryOfCollege);
        }

        [Then(@"I am able to see updated '([^']*)' education qualification")]
        public void ThenIAmAbleToSeeUpdatedEducationQualification(string collegeName)
        {
            string newEducation = educationObj.GetEditedEducation();
            Assert.That(newEducation == collegeName, "College name not edited");
        }

        [When(@"I delete the existing education qualification '([^']*)'")]
        public void WhenIDeleteTheExistingEducationQualification(string collegeName)
        {
            educationObj.DeleteEducation(collegeName);
        }

        [Then(@"I am not able to see the deleted '([^']*)' education qualification anymore")]
        public void ThenIAmNotAbleToSeeTheDeletedEducationQualificationAnymore(string collegeName)
        {
            string newEducation = educationObj.GetDeletedEducation();
            Assert.That(newEducation != collegeName, "College name not deleted");
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
    
        }


    }
}
