﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamTranXuanTan_2122110248.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult AllProductList() {
            return View();
        }
        public ActionResult AllProductGrid()
        {
            return View();
        }
    }
}