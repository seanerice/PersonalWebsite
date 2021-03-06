﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Controllers {
	public class HomeController : Controller {
		public ActionResult Index () {
			return View();
		}

		public ActionResult About () {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Projects () {
			return View();
		}

		public ActionResult Contact () {
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Carousel(string id, string[] src) {
			ViewBag.id = id;
			ViewBag.links = src;
			return PartialView();
		}
	}
}