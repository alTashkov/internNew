using FactoryPattern.Factory;
using FactoryPattern.FactoryPatternTelerik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics;

            logistics = new RoadLogistics();
            logistics.PlanDelivery();

            logistics = new SeaLogistics();
            logistics.PlanDelivery();

            Console.WriteLine();

            var requests = new List<IHttpRequest>()
            {
                HttpRequestFactory.CreateRequest("get", "google.com", new string[] { "hello", "from me"}),
                HttpRequestFactory.CreateRequest("post","telerikacademy.com",new string[] { "message","test"}, "testing.txt", "multipart/form")
            };

            Console.WriteLine(requests[1]);
        }
    }
}
