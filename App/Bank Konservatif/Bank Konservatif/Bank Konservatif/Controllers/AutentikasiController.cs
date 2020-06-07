using Bank_Konservatif.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank_Konservatif.Controllers
{
    public class AutentikasiController : Controller
    {
        // GET: Autentikasi
        private BankKonservatifService.PembayaranServiceClient serviceBank = new BankKonservatifService.PembayaranServiceClient();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(nasabah user)
        {
            using(BankKonservatifEntities db = new BankKonservatifEntities())
            {
                var users = (from p in db.nasabahs where p.no_rekening == user.no_rekening && p.password == user.password select p).FirstOrDefault();
                if(users != null)
                {
                    Session["no_rek"] = users.no_rekening;
                    Session["saldo"] = users.saldo;
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Autentikasi");
        }
    }
}