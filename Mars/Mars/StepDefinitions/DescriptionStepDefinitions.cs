using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class DescriptionStepDefinitions:CommonDriver
    {
        Description descriptionObj = new Description();

        [Given(@"I logged into localhost successfully")]
        public void GivenILoggedIntoLocalhostSuccessfully()
        {
            driver = new ChromeDriver();
            Login loginObj = new Login(driver);
        }

        [When(@"I edit the description feature")]
        public void WhenIEditTheDescriptionFeature()
        {
            descriptionObj.AddDescription(driver);
        }

        [Then(@"I am able to see the description")]
        public void ThenIAmAbleToSeeTheDescription()
        {
            string descText = descriptionObj.GetDescription(driver);
            Assert.That(descText == "Hi I am a ballet dancer", "Description not saved");
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();

        }
    }
}
