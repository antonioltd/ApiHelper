using System.Collections.Generic;
using RestSharp;
using TechnicalTest;

namespace Framework.Models
{
    public class RequestDetails
    {
        public string ResourceEndpoint { get; set; }
        public Method  MethodType { get; set; }
        public IList<RequestParameter> ParameterList { get; set; }
        
    }
}
