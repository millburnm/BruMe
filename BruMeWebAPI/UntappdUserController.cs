using BruMeServices;
using System.Web.Http;

namespace BruMeWebAPI
{
    public class UntappdUserController
    {
        [HttpGet]
        public string GetUntappdUserInfo(string userName)
        {
            return "";// new UntappdUserServices().GetUntappdUserInfo(userName);
        }

        public string GetUntappdUserBeerList(string username)
        {

            return "";
        }
    }
}
