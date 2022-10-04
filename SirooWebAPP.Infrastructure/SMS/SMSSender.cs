using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirooWebAPP.Infrastructure.SMS
{
    public class SMSSender
    {
        public static IRestResponse SendToPattern()
        {
            var client = new RestClient("http://188.0.240.110/api/select");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"op\" : \"pattern\"" +
                ",\"user\" : \"yourUsername\"" +
                ",\"pass\":  \"yourPassword\"" +
                ",\"fromNum\" : \"100009\"" +
                ",\"toNum\": \"09122000098\"" +
                ",\"patternCode\": \"545\"" +
                ",\"inputData\" : [{\"smstext\": \"asdadas\"}]}"
                , ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response;
            //Console.WriteLine(response.Content);
        }
    }
}
