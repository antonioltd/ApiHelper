using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest;

namespace Framework
{
    public class ApiHelper
    {
        private ApiHelper(){}
        public IRestRequest Request { get; set; }
        public IRestClient Client { get; set; }
       
        private static ApiHelper instance = null;
        public static ApiHelper GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApiHelper();
                }
                return instance;
            }
        }
      
        public void CreateRequest(RequestDetails requestDetails)
        {
            Request = new RestRequest(requestDetails.ResourceEndpoint, requestDetails.MethodType);
        }

        public IRestResponse ExecuteRequest()
        {
            Client = new RestClient(ConfigurationManager.AppSettings["BaseUrl"]);
            
            return Client.Execute(Request);
        }

        public void ClearRequestParameters()
        {
            Request.Parameters.Clear();
        }
    }
}
