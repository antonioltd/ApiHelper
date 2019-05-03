using System;
using System.Configuration;
using NUnit.Framework;

namespace TechnicalTest
{
    [TestFixture]
    public class UnitTest1
    {
        //IRestClient client;
        //IRestRequest request;
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
        
    }

    
}
