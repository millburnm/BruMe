using System.IO;
using System.Net;

namespace BruMe
{
    public class UntappdRequest
    {
        private string CLIENTID;
        private string CLIENT_SECRET;
        private string UNTAPPD_URI;
        private WebRequest untappdRequest;

        public UntappdRequest()
        {
            UNTAPPD_URI = "https://api.untappd.com/v4/";
            CLIENTID = "E463EFF4F5D6B5045B670B70144E954AF97C98EB";
            CLIENT_SECRET = "FADF0A923C8EA78B36F564E228315C38A991DB36";
        }

        public string GetUntappdUserInfo(string userName)
        {
            string uri = string.Format("{0}user/info/{1}?client_id={2}&client_secret={3}", UNTAPPD_URI, userName, CLIENTID, CLIENT_SECRET);
            untappdRequest = WebRequest.Create(uri);
            untappdRequest.Method = "GET";
            
            var response = (HttpWebResponse)untappdRequest.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

    }
}
