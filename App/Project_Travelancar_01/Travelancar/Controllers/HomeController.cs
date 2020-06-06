using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travelancar.Models;

namespace Travelancar.Controllers
{
    public class HomeController : Controller
    {

        private Travelancar.maskapai_puyuh_air_service.PuyuhAirWebService puyuh = new maskapai_puyuh_air_service.PuyuhAirWebService();
        private static string nama_maskapai_all = "";
        private static int id_penerbangan_all = 0;
        private static int user_id = new int();


        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string nama = User.Identity.Name;
                int id = WebSecurity.GetUserId(nama);
                userId = id;
            }
            ViewBag.Message = "Selamat Datang Di Travelancar.";
            findTiket cari = new findTiket();
            cari.tanggalBerangkat = DateTime.Now;
            cari.jumlahPenumpang = 1;

            return View(cari);
        }

        [HttpPost]
        public ActionResult Index(findTiket cari)
        {
            ViewBag.Message = cari.jumlahPenumpang;
            List<Travelancar.maskapai_puyuh_air_service.penerbangan> daftarPuyuh = puyuh.getPenerbangan1(cari.kotaAsal, cari.kotaTujuan, cari.tanggalBerangkat).ToList();
            List<PenerbanganAll> daftarPenerbangan = new List<PenerbanganAll>();

        
            foreach (var a in daftarPuyuh)
            {
                PenerbanganAll p = new PenerbanganAll();
                p.harga = a.harga;
                p.id_penerbangan = a.id_penerbangan;
                p.jam_keberangkatan = a.jam_keberangkatan;
                p.kota_asal = a.kota_asal;
                p.kota_tujuan = a.kota_tujuan;
                p.nama_maskapai = a.nama_maskapai;
                p.tanggal_keberangkatan = a.tanggal_keberangkatan;
                daftarPenerbangan.Add(p);

            }
            List<PenerbanganAll> recommended = daftarPenerbangan.OrderBy(p => p.jam_keberangkatan).ThenBy(p => p.harga).ToList();
            return View("daftarpenerbangan", recommended);
        }
        public ActionResult DaftarTiket()
        {
            //Response.Write(bank_konservatif.cekTransaksiMasuk("dctsh5i2ezv", 500000));
            //Response.End();
            List<Travelancar.maskapai_puyuh_air_service.tiket> daftarPuyuh = puyuh.getPemesanan(userId).ToList();

            List<TiketAll> daftarTiket = new List<TiketAll>();
            foreach (var t in daftarPuyuh)
            {
                TiketAll tkt = new TiketAll();
                tkt.batas_waktu_bayar_atm = t.batas_waktu_bayar_atm;
                tkt.batas_waktu_bayar_internet_banking = t.batas_waktu_bayar_internet_banking;
                tkt.id_tiket = t.id_tiket;
                tkt.id_penerbangan = t.id_penerbangan;
                tkt.kode_bayar = t.kode_bayar;
                tkt.kode_booking = t.kode_booking;
                tkt.total_harga = t.total_harga;
                if (t.STATUS == "Belum Bayar")
                {
                    //Response.Write(bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga));
                    if (bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga) == "1" || bank_konservatif.cekTransaksiMasuk(tkt.kode_bayar, (int)tkt.total_harga) == 1)
                    {
                        int res = puyuh.bayar(tkt.id_tiket);
                        tkt.status = "Lunas";
                    }
                    else
                    {
                        tkt.status = t.STATUS;
                    }
                }
                else
                {
                    tkt.status = t.STATUS;
                }
                tkt.waktu_booking = t.waktu_booking;
                daftarTiket.Add(tkt);
                //Response.Write(tkt.kode_bayar +"   "+tkt.status +"  "+ tkt.total_harga +"\n");
            }
        }

        public ActionResult ShowTicket(int id, string maskapai)
        {

            if (maskapai == "itik_air")
            {
                
            }
            else if (maskapai == "pinguin_air")
            {
                
            }
            else
            {
                Travelancar.maskapai_puyuh_air_service.CompositeType ct = puyuh.getTiket(id);
                return View("tiketpuyuhair", ct);
            }
        }

        public ActionResult BookTiket(int idPenerbangan, string maskapai, int jumlahPenumpang)
        {
            List<PenumpangAll> penumpangs = new List<PenumpangAll>();
            namaMaskapai_univ = maskapai;
            idPenerbangan_univ = idPenerbangan;
            for (int i = 0; i < jumlahPenumpang; i++)
            {
                PenumpangAll p = new PenumpangAll();
                p.idPenerbangan = idPenerbangan;
                p.namaMaskapai = maskapai;
                p.nomor_identitas = "-";
                p.nama = "-";
                penumpangs.Add(p);
            }
            return View(penumpangs);
        }

        [HttpPost]
        public ActionResult BookTiket(IList<PenumpangAll> daftarPenumpang)
        {
            int res = 0;
            daftarPenumpang = daftarPenumpang ?? new List<PenumpangAll>();
            if (namaMaskapai_univ == "itik_air")
            {

            }
            else if (namaMaskapai_univ == "puyuh_air")
            {
                Travelancar.maskapai_puyuh_air_service.penumpang pen;
                List<Travelancar.maskapai_puyuh_air_service.penumpang> penumpangs = new List<maskapai_puyuh_air_service.penumpang>();
                foreach (var p in daftarPenumpang)
                {
                    pen = new maskapai_puyuh_air_service.penumpang();
                    pen.nama = p.nama;
                    pen.nomor_identitas = p.nomor_identitas;
                    penumpangs.Add(pen);
                }
                res = puyuh.booking(idPenerbangan_univ, penumpangs.ToArray(), userId);
            }
            else
            {
            }
            
        }

        public ActionResult BayarAtm(string kodeBayar, int jumlah, DateTime batas)
        {
            ViewBag.kode = kodeBayar;
            ViewBag.jumlah = jumlah;
            ViewBag.batas = batas;
            return View();
        }
    }
}