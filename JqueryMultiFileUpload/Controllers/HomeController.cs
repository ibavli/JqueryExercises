using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryMultiFileUpload.Controllers
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

        public ActionResult DosyaYukleme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DosyaYukleme(IEnumerable<HttpPostedFileBase> dosyalar)
        {
            foreach (var dosya in dosyalar)
            {
                if (dosya != null)
                {
                    string dosyaYolu = Path.GetFileName(dosya.FileName);//Dosya yolunu al.

                    var yuklenecekYer = Path.Combine(Server.MapPath("~/Dosyalar"), dosyaYolu);//Dosyanın yüklenecek yolunu al.

                    dosya.SaveAs(yuklenecekYer);//Dosyayı yüklenecek yere yükle.
                }
            }
        
            return View();
        }

    }
}