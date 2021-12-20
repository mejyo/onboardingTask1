using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        Education education;
        Boolean allFieldsError = false;
        [Given(@"I am on Home page")]
        public void GivenIAmOnHomePage()
        {
            education = new Education();
        }

        [When(@"I select Education")]
        public void WhenISelectEducation()
        {
            education.EducationButtonClick();
        }

        [When(@"I click On Add New button")]
        public void WhenIClickOnAddNewButton()
        {
            education.AddNewButtonClick();
        }

        [When(@"I entered all given values (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIEnteredAllGivenValues(String universityName, String country, String title, String degree, String year)
        {
          

            if (universityName == "" || country == "" || title == "" || degree == "" || year == "")
            {
                allFieldsError = true;
            } else
            {
               
                allFieldsError = false;
            }

            education.EnteredGivenValuesForAdd(universityName, country, title, degree, year);
        }

        [When(@"I click On Add button")]
        public void WhenIClickOnAddButton()
        {
            education.AddButtonClick();
        }

        [When(@"I click On Edit Icon")]
        public void WhenIClickOnEditIcon()
        {
            education.EditIconClick();
        }

        [When(@"I updated all given values (.*), (.*), (.*), (.*), (.*)")]
        public void WhenIUpdatedAllGivenValues(String universityName, String country, String title, String degree, String year)
        {
            if (universityName == "" || country == "" || title == "" || degree == "" || year == "")
            {
              
                allFieldsError = true;
            }
            else
            {
                allFieldsError = false;
            }
            education.EnteredGivenValuesForUpdate(universityName, country, title, degree, year);
        }

        [When(@"I click On Update button")]
        public void WhenIClickOnUpdateButton()
        {
            education.UpdateButtonClick();
        }

        [When(@"I click on Delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            education.DeleteButtonClick();
        }

        [Then(@"I expect the (.*) should be displyed on the screen")]
        public void ThenIExpectTheShouldBeDisplyedOnTheSreen(String message)
        {
            String actualMessage = education.getActualMessage(allFieldsError);
            Assert.AreEqual(message, actualMessage);
        }
    }
}
