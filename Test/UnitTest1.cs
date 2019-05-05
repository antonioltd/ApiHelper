﻿using System;
using System.Configuration;
using NUnit.Framework;
using Framework;
using RestSharp;
using System.Collections.Generic;
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
            // client = new RestClient("http://jsonplaceholder.typicode.com");
            // request = new RestRequest("/users", Method.GET);
            
            //IRestResponse response = client.Execute(request);

            //var obj =JsonConvert.DeserializeObject<IList<UserResponseModel>>(response.Content);
            //var a = obj.Where(x => x.name.Equals("Leanne Graham"));
            //foreach (var s in a)
            //{
            //    Console.WriteLine(s.id);
            //    Console.WriteLine(s.name);
            //    Console.WriteLine(s.username);
            //    Console.WriteLine(s.address.city);
            //    Console.WriteLine(s.address.geo.lat);
            //    Console.WriteLine(s.address.geo.lng);

             Console.WriteLine(ConfigurationManager.AppSettings["BaseUrl"]);
            //}
           
        }


        [Test]
        public void UsersTest()
        {
            var api = ApiHelper.GetInstance;

            api.CreateRequest(new RequestDetails
            {
                ResourceEndpoint = Endpoint.Posts,
                MethodType = Method.GET               
            });

            _response = api.ExecuteRequest();
            Assert.AreEqual(200, (int)_response.StatusCode);

            var data = api.ResponseData<IList<UserResponseModel>>(_response);
        }
        
    }
}