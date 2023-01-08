using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions:CommonDriver
    {
        Skill skillObj = new Skill();

        [When(@"I navigate to the skills tab")]
        public void WhenINavigateToTheSkillsTab()
        {
            skillObj.GoToSkillTab();
        }

        [When(@"I add new '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddNewAndToTheProfile(string skill, string level)
        {
            skillObj.AddSkill(skill, level);
        }

        [Then(@"I am able to see my skills '([^']*)'")]
        public void ThenIAmAbleToSeeMySkills(string skill)
        {
            string addedNewSkill= skillObj.GetaddedSkill(skill);
            Assert.That(addedNewSkill == skill, "Skill not added");
        }

        [When(@"I edit the existing skills '([^']*)', '([^']*)'")]
        public void WhenIEditTheExistingSkills(string skill, string level)
        {
            skillObj.EditSkill(skill, level);
        }

        [Then(@"I am able to see the edited skills '([^']*)'")]
        public void ThenIAmAbleToSeeTheEditedSkills(string skill)
        {
            string editedSkill = skillObj.GetEditedSkill(skill);
            Assert.That(editedSkill == skill, "Skill not edited");
        }

        [When(@"I delete a skill '([^']*)'")]
        public void WhenIDeleteASkill(string skill)
        {
            skillObj.DeleteSkill(skill);
        }

        [Then(@"I am not able to see the skill in my profile '([^']*)'")]
        public void ThenIAmNotAbleToSeeTheSkillInMyProfile(string skill)
        {
            string editedSkill = skillObj.GetDeletedSkill(skill);
            Assert.That(editedSkill != skill, "Skill not deleted");
        }
    }
}
