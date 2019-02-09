using JquerySehirVeSemtler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JquerySehirVeSemtler.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        List<Il> iller = new List<Il>()
        {
            new Il{ Id = 1, Ad = "İzmir" },
            new Il{ Id = 2, Ad = "İstanbul" },
            new Il{ Id = 3, Ad = "Antalya" },
            new Il{ Id = 4, Ad = "Denizli" }
        };
        List<Ilceler> izmirinIlceleri = new List<Ilceler>()
        {
            new Ilceler { Id = 1, Ad = "Karşıyaka", Il = }
        }
    }
}