﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstApp.Controllers
{
    public class SchoolController : Controller
    {
        
        public ActionResult FirstView(int ? i)
        {
           
            Response.Write("value" + i);
            return View("FirstView");
        }
    }
}
