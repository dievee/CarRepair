﻿using CarRepair.Attributes;
using CarRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarRepair.Controllers
{
    public class HomeController : Controller 
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
    
        }
    }
}