using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Models;
using TechnicalTest;
using TechnicalTest.ResponseModel;


namespace Framework
{
    public class ApiHelper
    {
        private ApiHelper() { }

        private IRestRequest _request;

        private IRestClient _client;

        private IRestResponse _response;

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

        private IRestRequest CreateRequest(RequestDetails requestDetails, object jsonBody = null)
        {
            _request = new RestRequest(requestDetails.ResourceEndpoint, requestDetails.MethodType);

            if (requestDetails.RequestParameterList == null) return _request;

            foreach (var parameter in requestDetails.RequestParameterList)
            {
                _request.AddParameter(parameter.Name, parameter.Value, parameter.ParameterType);
            }

            return _request;

        }

        public IRestResponse WriteAPost(WriteAPostScenarioType sdfg)
        {

            _request = CreateRequest(new RequestDetails()
            {
                ResourceEndpoint = Endpoint.Posts,
                MethodType = Method.POST,
                RequestParameterList = new List<RequestParameter>()
                    {
                        new RequestParameter()
                        {
                            ParameterType = ParameterType.HttpHeader,
                            Name = "Content-Type",
                            Value = "application/json"
                        }                       
                    }
            });

            


        }

        private IRestResponse ExecuteRequest(IRestRequest request)
        {
            _client = new RestClient(AppSettings.BaseUrl);

            _response = _client.Execute(request);

            request.Parameters.Clear();

            return _response;

        }


        public IRestResponse GetAllPosts()
        {
             _request = CreateRequest(new RequestDetails
            {
                MethodType = Method.GET,
                ResourceEndpoint = $"{Endpoint.Posts}"

            });

            return ExecuteRequest(_request);
        }

        public IRestResponse GetSpecificPost(int id)
        {
            _request = CreateRequest(new RequestDetails
            {
                MethodType = Method.GET,
                ResourceEndpoint = $"{Endpoint.Posts}/{id}"

            });

            return ExecuteRequest(_request);
        }

        public IRestResponse GetUserInformation(string id)
        {
            _request = CreateRequest(new RequestDetails
            {
                MethodType = Method.GET,
                ResourceEndpoint = $"{Endpoint.Users}/{1}"
            });

            return ExecuteRequest(_request);
        }

        public T ResponseContent<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

    }

}
