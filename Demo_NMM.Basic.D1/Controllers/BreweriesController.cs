﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_NMM.Basic.Controllers
{
    public class BreweriesController : Controller
    {
        // GET: Breweries
        public ActionResult Index()
        {
            return View();
        }
    }
}