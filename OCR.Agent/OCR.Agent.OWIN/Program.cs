
using Microsoft.Owin.Hosting;
using OCR.Agent.Register;
using System;
using System.Net.Http;

namespace OCR.Agent.OWIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            Connect connect = new Connect();

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.ReadLine();
            }
        }
    }
}
