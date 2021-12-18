using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public EducationSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I am on Home page")]
        public void GivenIAmOnHomePage()
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I select (.*)")]
        public void WhenISelect(string p0)
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I click On Add New button")]
        public void WhenIClickOnAddNewButton()
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I expect that the fields RMIT, Canada, B\.A, abc, (.*) displays on the page")]
        public void WhenIExpectThatTheFieldsRMITCanadaB_AAbcDisplaysOnThePage(int p0)
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I click On Add button")]
        public void WhenIClickOnAddButton()
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I expect that the fields CMRIT, India, M\.A, abc, (.*) displays on the page")]
        public void WhenIExpectThatTheFieldsCMRITIndiaM_AAbcDisplaysOnThePage(int p0)
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I click On Update button")]
        public void WhenIClickOnUpdateButton()
        {
            _scenarioContext.Set("");
        }
        
        [When(@"I click on delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            _scenarioContext.Set("");
        }
        
        [Then(@"I expect the Education has been added should be displyed on the screen")]
        public void ThenIExpectTheEducationHasBeenAddedShouldBeDisplyedOnTheScreen()
        {
            _scenarioContext.Set("");
        }
        
        [Then(@"I expect the Education has been updated should be displyed on the screen")]
        public void ThenIExpectTheEducationHasBeenUpdatedShouldBeDisplyedOnTheScreen()
        {
            _scenarioContext.Set("");
        }
        
        [Then(@"I expect the Education entry successfully removed should be displyed on the screen")]
        public void ThenIExpectTheEducationEntrySuccessfullyRemovedShouldBeDisplyedOnTheScreen()
        {
            _scenarioContext.Set("");
        }
    }
}
