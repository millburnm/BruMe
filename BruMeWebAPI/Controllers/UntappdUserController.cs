using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BruMeWebAPI.Controllers
{
    //[RoutePrefix("/BruMeWebAPI/")]
    public class UntappdUserController : ApiController
    {
        [HttpGet]
      //  [Route("UntappdUser")]
        public string[] Get()
        {
            return new string[]
            {
             "Hello",
             "World"
            };
        }
    }
}
