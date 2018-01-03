using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apprenda.NET.TestApplication.Controllers
{
    public class TestsController : ApiController
    {
        public string Get()
        {
            return "Success";
        }
    }
}
