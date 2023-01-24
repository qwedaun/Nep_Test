using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
namespace Nep_PR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient();
            var request = new RestRequest("https://api.coindesk.com/v1/bpi/currentprice.json", Method.Get);
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ModelsApi.Rootobject>(response.Content);
            Console.WriteLine(result.bpi.USD.rate);
            Console.WriteLine(result.bpi.USD.description);
           
            Console.ReadLine();

        }
    }
}
