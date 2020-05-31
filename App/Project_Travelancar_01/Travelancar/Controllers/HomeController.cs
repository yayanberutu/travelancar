using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travelancar.Controllers
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

        public ActionResult BookFlight()
        {
            return View();
        }

        public ActionResult Pesan()
        {
            return View();
        }

        public ActionResult penerbangan()
        {
            penerbangan1 cari = new penerbangan1();
            cari.jumlahPenumpang = 1;

            return View(cari);
        }
        public ActionResult pemesanan_kamar()
        {
            ViewBag.Message = "Selamat Datang Di Travelancar.";

            return View();
        }

        public ActionResult DaftarPenerbangan() {


            return View();
        }
    }
}