using Newtonsoft.Json;
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
        private ApiHelper() { }
        private IRestRequest Request { get; set; }
        private IRestClient Client { get; set; }

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

            if (requestDetails.ParameterList != null)
            {
                foreach (var parameter in requestDetails.ParameterList)
                {
                    Request.AddParameter(parameter.Key, parameter.Value, parameter.ParameterType);
                }
            }
           
        }

        public IRestResponse ExecuteRequest()
        {
            Client = new RestClient(AppSettings.BaseUrl);

            return Client.Execute(Request);
        }

        public void ClearRequestParameters()
        {
            Request.Parameters.Clear();
        }

        public T ResponseData<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
