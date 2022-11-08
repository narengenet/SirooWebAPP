
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace SirooWebAPP.Infrastructure.SMS
{
    public class SMSSender
    {

        public static string SendToPattern(string toNumber, string name, string verificationcode)
        {

            //RestClientPatternV2Sample.SendThePattern.SendPattern();

            //return "ok";

            var client = new RestClient("http://188.0.240.110/api/select");
            var request = new RestRequest(Method.POST);

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"op\" : \"pattern\"" +
                ",\"user\" : \"09124497308\"" +
                ",\"pass\":  \"cisco2600\"" +
                ",\"fromNum\" : \"10004223\"" +
                ",\"toNum\": \"" + toNumber + "\"" +
                ",\"patternCode\": \"krqlh4qju5cbwwm\"" +
                ",\"inputData\" : [{\"name\": \""+name+"\",\"verification-code\": \""+verificationcode+"\"}]}"
                , ParameterType.RequestBody);
            IRestResponse iresp = client.Execute(request);

            return "ok";
            //Console.WriteLine(response.Content);
        }
    }
}
