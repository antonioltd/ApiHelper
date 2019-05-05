using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TechnicalTest.Steps
{
    [Binding]
    public class FeatureSteps
    {

        [Given(@"Posts rest endpoint is up")]
        public void GivenPostsRestEndpointIsUp()
        {
            Console.WriteLine("Post rest endpoint is up!!!");
        }

        [When(@"I request to get a post with id number (.*)")]
        public void WhenIRequestToGetAPostWithIdNumber(int p0)
        {
            Console.WriteLine("Id number is " + p0);
        }

        [Then(@"the system will response (.*) code")]
        public void ThenTheSystemWillResponseCode(int p0)
        {
            Console.WriteLine("Response: " + p0);
        }

        [Then(@"the title of the post is '(.*)'")]
        public void ThenTheTitleOfThePostIs(string p0)
        {
            Console.WriteLine(p0);
            ;
        }


    }
}
