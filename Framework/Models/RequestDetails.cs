using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class RequestDetails
    {
        public string Endpoint { get; set; }
        public Method  MethodType { get; set; }
        public IList<RequestParameters> MyProperty { get; set; }
    }
}
