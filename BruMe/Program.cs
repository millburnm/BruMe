using Newtonsoft.Json;
using BruMeObjects;

namespace BruMe
{
    class Program
    {
        static void Main(string[] args)
        {
            UntappdRequest request = new UntappdRequest();
            string response = request.GetUntappdUserInfo("GARFUNKALOW");
            User garfunkabro = JsonConvert.DeserializeObject<RootObject>(response).response.user;
        }
    }
}
