using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.ApiControllers
{
    public class HelloApiController : ApiController
    {
        [HttpGet]
        public object Get()
        {
            return new { Hello = "World Api" };
        } 
    }
}
