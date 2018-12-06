using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace Demos.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://localhost:9000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                var client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/values").Result;
                Console.WriteLine("response =>");
                Console.WriteLine(response);

                Console.WriteLine();
                Console.WriteLine("response Content =>");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Console.WriteLine();
                Console.WriteLine("press any key to exit!");
                Console.ReadLine();
            } 
        }
    }
}
