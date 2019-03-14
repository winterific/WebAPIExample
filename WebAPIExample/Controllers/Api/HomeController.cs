﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIExample.Controllers.Api
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello world from the default home controller";
        }
    }
}
