using System;
using System.Configuration;
using NUnit.Framework;
using Framework;
using RestSharp;
using System.Collections.Generic;
using Framework.Models;
using TechnicalTest.ResponseModel;

namespace TechnicalTest
{
    [TestFixture]
    public class UnitTest1
    {
        //IRestClient client;
        //IRestRequest request;
        private IRestResponse _response;
        [Test]
        public void TestMethod1()
        {
                       
        }


        [Test]
        public void UsersTest()
        {

            var api = ApiHelper.GetInstance;

            _response = api.GetUserInformation("1");


        }

        [Test]
        public void PostsTest()
        {
            var api = ApiHelper.GetInstance;

           _response = api.GetSpecificPost(1);
        }
        
    }
}
