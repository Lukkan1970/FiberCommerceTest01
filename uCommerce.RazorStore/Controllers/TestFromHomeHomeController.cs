﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UCommerce.RazorStore.Controllers
{
    public class TestFromHomeHomeController : RenderMvcController
    {
        // GET: TestFromHomeHome
        [HttpGet]
        public ActionResult Index()
        {
            return View("/views/frontpage.cshtml");
        }
    }
}