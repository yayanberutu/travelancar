using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travelancar.ItikAirService;
using Travelancar.Models;
using WebMatrix.WebData;

namespace Travelancar.Controllers
{
    public class HomeController : Controller
    {
        private Travelancar.ItikAirService.Service1Client itikAir = new ItikAirService.Service1Client();
        private Travelancar.maskapai_puyuh_air_service.PuyuhAirWebServiceClient puyuh = new maskapai_puyuh_air_service.PuyuhAirWebServiceClient();
        private Travelancar.maskapai_piguin_air_service.Service1Client piguin = new maskapai_piguin_air_service.Service1Client();
        
        private static string nama_maskapai_all = "";
        private static int id_penerbangan_all= 0;
        private static int user_id = new int();

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string nama = User.Identity.Name;
                int id = WebSecurity.GetUserId(nama);
                user_id = id;
            }

            return View();
        }

        public ActionResult ListPenerbangan()
        {
            findTiket cari = new findTiket();
            cari.tanggalBerangkat = DateTime.Now;
            cari.jumlahPenumpang = 1;

            return View(cari);
        }

        [HttpPost]
        public ActionResult Index(findTiket cari)
        {
            ViewBag.Message = cari.jumlahPenumpang;
            List<Travelancar.ItikAirService.penerbangan> ListItik = itikAir.GetPenerbangan(cari.kotaAsal, cari.kotaTujuan, cari.tanggalBerangkat).ToList();
            List<Travelancar.maskapai_puyuh_air_service.penerbangan> daftarPuyuh = puyuh.getPenerbangan1(cari.kotaAsal, cari.kotaTujuan, cari.tanggalBerangkat).ToList();
            List<Travelancar.maskapai_piguin_air_service.penerbangan1> daftarPiguin = piguin.getPenerbangan(cari.kotaAsal, cari.kotaTujuan, cari.tanggalBerangkat).ToList();

            List<PenerbanganAll> daftarPenerbangan = new List<PenerbanganAll>();

            //itik air
            foreach (var k in ListItik)
            {
                PenerbanganAll p = new PenerbanganAll();
                p.id_penerbangan = k.id_penerbangan;
                p.harga = k.harga;
                p.jam_keberangkatan = k.jam_keberangkatan;
                p.kota_asal = k.kota_asal;
                p.kota_tujuan = k.kota_tujuan;
                p.nama_maskapai = k.nama_maskapai;
                p.tanggal_keberangkatan = k.tanggal_keberangkatan;

                daftarPenerbangan.Add(p);

            }

            //puyuh air
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

            //pinguin air
            foreach(var a in daftarPiguin)
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
            return View("DaftarPenerbangan", recommended);
        }

        public ActionResult DaftarTiket()
        {
        
            List<Travelancar.ItikAirService.tiket> ListItik = itikAir.GetPemesanan(user_id).ToList();
            List<Travelancar.maskapai_puyuh_air_service.tiket> daftarPuyuh = puyuh.getPemesanan(user_id).ToList();
            List<Travelancar.maskapai_piguin_air_service.tiket> daftarPiguin = piguin.getPemesanan(user_id).ToList();



            List<TiketAll> daftarTiket = new List<TiketAll>();
            //itik air
            foreach (var t in ListItik)
            {
                TiketAll tkt = new TiketAll();
                tkt.batas_waktu_bayar_atm = t.batas_waktu_bayar_atm;
                tkt.batas_waktu_bayar_internet_banking = t.batas_waktu_bayar_internet_banking;
                tkt.id_tiket = t.id_tiket;
                tkt.id_penerbangan = t.id_penerbangan;
                tkt.kode_bayar = t.kode_bayar;
                tkt.kode_booking = t.kode_booking;
                tkt.total_harga = t.total_harga;
              /*  if (t.STATUS == "Belum Bayar")
                {
                    if (bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga) == "1" || bank_konservatif.cekTransaksiMasuk(tkt.kode_bayar, (int)tkt.total_harga) == 1)
                    {
                        int res = itikAir.Bayar(tkt.id_tiket);
                        tkt.STATUS = "Lunas";
                    }
                    else
                    {
                        tkt.STATUS = t.STATUS;
                    }
                }
                else
                {
                    tkt.STATUS= t.STATUS;
                }*/
                tkt.waktu_booking = t.waktu_booking;
                tkt.id_penerbangan = t.id_penerbangan;
                daftarTiket.Add(tkt);
            }

            //puyuh air
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
            /*    if (t.STATUS == "Belum Bayar")
                {
                    if (bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga) == "1" || bank_konservatif.cekTransaksiMasuk(tkt.kode_bayar, (int)tkt.total_harga) == 1)
                    {
                        int res = puyuh.bayar(tkt.id_tiket);
                        tkt.STATUS = "Lunas";
                    }
                    else
                    {
                        tkt.STATUS = t.STATUS;
                    }
                }
                else
                {
                    tkt.STATUS = t.STATUS;
                }*/
                tkt.waktu_booking = t.waktu_booking;
                tkt.id_penerbangan = t.id_penerbangan;
                daftarTiket.Add(tkt);
              }


            //piguin air
            foreach(var t in daftarPiguin)
            {
                TiketAll tkt = new TiketAll();
                tkt.batas_waktu_bayar_atm = t.batas_waktu_bayar_atm;
                tkt.batas_waktu_bayar_internet_banking = t.batas_waktu_bayar_internet_banking;
                tkt.id_tiket = t.id_tiket;
                tkt.id_penerbangan = t.id_penerbangan;
                tkt.kode_bayar = t.kode_bayar;
                tkt.kode_booking = t.kode_booking;
                tkt.total_harga = t.total_harga;
                /*if (t.STATUS == "Belum Bayar")
                {
                    //Response.Write(bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga));
                    if (bank_bung.getIndex(tkt.kode_bayar, tkt.total_harga) == "1" || bank_konservatif.cekTransaksiMasuk(tkt.kode_bayar, (int)tkt.total_harga) == 1)
                    {
                        int res = piguin.bayar(tkt.id_tiket);
                        tkt.STATUS = "Lunas";
                    }
                    else
                    {
                        tkt.STATUS = t.STATUS;
                    }
                }
                else
                {
                    tkt.STATUS = t.STATUS;
                }*/
                tkt.waktu_booking = t.waktu_booking;
                tkt.id_penerbangan = t.id_penerbangan;
                daftarTiket.Add(tkt);
             }


            daftarTiket = daftarTiket.OrderByDescending(t => t.waktu_booking).ToList();
            return View(daftarTiket);
        }

        public ActionResult ShowTicket(int id, string maskapai)
        {
            if (maskapai == "itik_air")
            {
                Travelancar.ItikAirService.CompositeType composite = itikAir.GetTiket(id);
                return View("tiketitikair", composite);
            }
            else if (maskapai == "pinguin_air")
            {
                Travelancar.maskapai_puyuh_air_service.CompositeType ct = puyuh.getTiket(id);
                return View("tiketpuyuhair", ct);
            }
            else
            {
                Travelancar.maskapai_piguin_air_service.CompositeType ct = piguin.getTiket(id);
                return View("tiketpiguinair", ct);
            }

        }
        public ActionResult BookTiket(int idPenerbangan, string maskapai, int jumlahPenumpang)
        {
            List<PenumpangAll> penumpangs = new List<PenumpangAll>();
            nama_maskapai_all = maskapai;
            id_penerbangan_all = idPenerbangan;
            for (int i = 0; i < jumlahPenumpang; i++)
            {
                PenumpangAll p = new PenumpangAll();
                p.id_penerbangan= idPenerbangan;
                p.nama_maskapai = maskapai;
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
            if (nama_maskapai_all == "itik_air")
            {
                Travelancar.ItikAirService.penumpang pass;
                List<Travelancar.ItikAirService.penumpang> penumpangs = new List<ItikAirService.penumpang>();
                foreach (var pr in daftarPenumpang)
                {
                    pass = new ItikAirService.penumpang();
                    pass.nama = pr.nama;
                    pass.nomor_identitas = pr.nomor_identitas;
                    penumpangs.Add(pass);
                }
                res = itikAir.Booking(id_penerbangan_all, penumpangs.ToArray(), user_id);
            }
            else if (nama_maskapai_all == "puyuh_air")
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
                res = puyuh.booking(id_penerbangan_all, penumpangs.ToArray(), user_id);
            }
            else
            {
                Travelancar.maskapai_piguin_air_service.penumpang pen;
                List<Travelancar.maskapai_piguin_air_service.penumpang> penumpangs = new List<maskapai_piguin_air_service.penumpang>();
                foreach (var p in daftarPenumpang)
                {
                    pen = new maskapai_piguin_air_service.penumpang();
                    pen.nama = p.nama;
                    pen.nomor_identitas = p.nomor_identitas;
                    penumpangs.Add(pen);
                }
                res = piguin.booking(id_penerbangan_all, penumpangs.ToArray(), user_id);
            }

            return View("pesanbookingtiket");
        }



    }
}