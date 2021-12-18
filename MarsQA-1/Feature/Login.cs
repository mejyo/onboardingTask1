using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        private readonly ScenarioContext _scenarioContext;

        public Login(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            //ScenarioContext.Current.Pending(); - //Obsolete
            _scenarioContext.Set("");
        }

    }
}
