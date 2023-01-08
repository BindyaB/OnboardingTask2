using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions:CommonDriver
    {
        Language languageObj = new Language();

        [When(@"I navigate to languages tab")]
        public void WhenINavigateToLanguagesTab()
        {
            languageObj.GoToLanguageTab(driver);
        }

        [When(@"I add new '([^']*)', '([^']*)' to my profile")]
        public void WhenIAddNewToMyProfile(string language, string level)
        {
            languageObj.AddLanguage(driver, language, level);
        }

        [Then(@"I am able to see '([^']*)' added to my profile")]
        public void ThenIAmAbleToSeeAddedToMyProfile(string language)
        {
            string newLanguage = languageObj.GetLanguage(driver);
            Assert.That(newLanguage == language, "Language not added");
        }

        [When(@"I edit the existing language '([^']*)', '([^']*)'")]
        public void WhenIEditTheExistingLanguage(string language, string level)
        {
            languageObj.EditLanguage(driver, language, level);
        }

        [Then(@"I am able to see the edited language '([^']*)'")]
        public void ThenIAmAbleToSeeTheEditedLanguage(string language)
        {
            string editedLanguage = languageObj.GetLanguage(driver);
            Assert.That(editedLanguage == language, "Language not edited");
        }

        [When(@"I delete a language '([^']*)'")]
        public void WhenIDeleteALanguage(string language)
        {
            languageObj.DeleteLanguage(driver);
        }

        [Then(@"I am not able to see the language in profile '([^']*)'")]
        public void ThenIAmNotAbleToSeeTheLanguageInProfile(string language)
        {
            string editedLanguage = languageObj.GetDeletedLang(driver, language);
            Assert.That(editedLanguage != language, "Language not deleted");
        }


    }
}
