using Framework;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.ResponseModel;
using TechnicalTest.ScenarioType;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TechnicalTest.Steps
{
    [Binding]
    public class FeatureSteps
    {
        ApiHelper api = ApiHelper.GetInstance;
        private IRestResponse _response;

        [Given(@"Posts rest endpoint is up")]
        public void GivenPostsRestEndpointIsUp()
        {
            Console.WriteLine("Posts rest endpoint is up.");
        }

        [When(@"I request to get a post with id number (\d+)")]
        public void RequestToGetPostWithIdNumber(int id)
        {
           _response = api.GetSpecificPost(id);           
        }

        [When(@"I request to write a post with detail:")]
        public void WriteAPost(Table table)
        {
            var post = table.CreateInstance<WriteAPostScenarioType>();
            _response = api.WriteAPost(post);
        }

        [Then(@"the system will return (\d+) code")]
        public void SystemResponseCode(int statusCode)
        {
            Assert.That((int)_response.StatusCode, Is.EqualTo(200));
        }

        [Then(@"the title of the post is '(.*)'")]
        public void TitleOfThePost(string title)
        {
            var post = api.ResponseContent<Posts>(_response);
            Assert.AreEqual(title, post.title);
        }

        [When(@"I request to get all posts")]
        public void RequestToGetAllPosts()
        {
            _response = api.GetAllPosts();
        }

        [Then(@"the total number of posts is (\d+)")]
        public void ThenTheTotalNumberOfPostsIs(int numberOfPosts)
        {
            var posts = api.ResponseContent<IList<Posts>>(_response);

            Assert.AreEqual(numberOfPosts, posts.Count);
        }



    }
}
