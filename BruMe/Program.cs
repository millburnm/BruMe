using BruMeDomainObjects.UntappdObjects;
using BruMeServices;
using Newtonsoft.Json;
using Microsoft.Owin.Hosting;
using System;

namespace BruMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //UntappdRequest request = new UntappdRequest();
            //string response = request.GetUntappdUserInfo("GARFUNKALOW");
            //User garfunkabro = JsonConvert.DeserializeObject<RootObject>(response).response.user;

            //string uri = "";// string.Format("{0}user/info/{1}?client_id={2}&client_secret={3}", UNTAPPD_URI, userName, CLIENTID, CLIENT_SECRET);
            //WebRequest getUntappdUserInfo = WebRequest.Create(uri);
            //getUntappdUserInfo.Method = "GET";

            //var response = new UntappdUserServices().GetUntappdUserInfo("delphi53");
            ////User user = JsonConvert.DeserializeObject<RootObject>(response).response.user;
            //var beerList = new UntappdUserServices().GetUntappdUserBeerList("delphi53");

            using (WebApp.Start<BruMeWebAPI.Startup>("http://localhost:8080"))
            {
                Console.WriteLine("BruMeWebAPI started");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
