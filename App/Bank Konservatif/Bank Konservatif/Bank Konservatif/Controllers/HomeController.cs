using Bank_Konservatif.BankKonservatifService;
using Bank_Konservatif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank_Konservatif.Controllers
{
    public class HomeController : Controller
    {
        private BankKonservatifService.PembayaranServiceClient serviceBank = new BankKonservatifService.PembayaranServiceClient();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Saldo()
        {
            ViewBag.Saldo = Session["saldo"];
            return View();
        }

        [HttpGet]
        public ActionResult Pembayaran()
        {
            Bank_Konservatif.BankKonservatifService.Pembayaran[] listPembayaran = serviceBank.getPembayaranByNorek(Session["no_rek"].ToString());
            List<Bank_Konservatif.Models.Pembayaran> lP = listPembayaran.OfType<Bank_Konservatif.Models.Pembayaran>().ToList();
            ViewBag.lp = lP;
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

    }
}