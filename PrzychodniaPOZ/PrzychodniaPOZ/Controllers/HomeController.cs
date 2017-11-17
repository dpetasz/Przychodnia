using PrzychodniaPOZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrzychodniaPOZ.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        PrzychodniaPOZEntities db = new PrzychodniaPOZEntities();
        public ActionResult Index()
        {
            return View(db.pokazPacjent());
        }

        

    }
}