using JqueryChooseExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryChooseExercises.Controllers
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

        public ActionResult TumKayitlariSec()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun
                        {
                            Id = 1, Ad = "Bilgisayar", Fiyat = 1200
                        },
                        new Urun
                        {
                            Id = 2, Ad = "Notebook", Fiyat = 2200
                        },
                        new Urun
                        {
                            Id = 3, Ad = "Tablet PC", Fiyat = 800
                        },
                        new Urun
                        {
                            Id = 4, Ad = "Netbook", Fiyat = 600
                        },
                        new Urun
                        {
                            Id = 5, Ad = "Akıllı Telefon", Fiyat = 1750
                        }
            };
            ViewBag.urunler = urunler;
            return View();

        }

        [HttpPost]
        public void SecilileriSil(string seciliIdler)
        {
            
        }


        
    }
}
