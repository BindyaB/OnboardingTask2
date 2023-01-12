using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinitions:CommonDriver
    {
        Certification certificationObj = new Certification();

        [When(@"I navigate to the certification tab")]
        public void WhenINavigateToTheCertificationTab()
        {
            certificationObj.GoToCertification();
        }

        [When(@"I add '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIAdd(string certificate, string certifiedBy, string year)
        {
            certificationObj.AddCertification(certificate, certifiedBy, year);
        }

        [Then(@"I am able to see the '([^']*)' added certification")]
        public void ThenIAmAbleToSeeTheAddedCertification(string certificate)
        {
            string newCertification = certificationObj.GetCertification();
            Assert.That(newCertification == certificate, "Certification not added");

        }

        [When(@"I edit the existing certification '([^']*)', '([^']*)'")]
        public void WhenIEditTheExistingCertification(string certificate, string certifiedBy)
        {
            certificationObj.EditCerification(certificate, certifiedBy);
        }

        [Then(@"I am able to see updated '([^']*)' Certification")]
        public void ThenIAmAbleToSeeUpdatedCertification(string certificate)
        {
            string newCertification = certificationObj.GetEditedCertification();
            Assert.That(newCertification == certificate, "Certification not edited");

        }

        [When(@"I delete the existing certification '([^']*)'")]
        public void WhenIDeleteTheExistingCertification(string certificate)
        {
            certificationObj.DeleteCertification(certificate);

        }

        [Then(@"I am not able to see the deleted '([^']*)' certification")]
        public void ThenIAmNotAbleToSeeTheDeletedCertification(string certificate)
        {
            string newCertification = certificationObj.GetDeletedCertification();
            Assert.That(newCertification != certificate, "Certification not deleted");

        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();

        }

    }
}
