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
        private Travelancar.hotel_kasur_empuk_service.Service1Client kasur_empuk = new hotel_kasur_empuk_service.Service1Client();
        private Travelancar.hotel_mawar_melati_service.Service1Client mawar_melati = new hotel_mawar_melati_service.Service1Client();
        private static string nama_maskapai_all = "";
        private static int id_penerbangan_all = 0;
        private static int user_id = new int();


        
        public ActionResult Hotel()
        {
            List<Travelancar.hotel_kasur_empuk_service.kamar> kamarKasurEmpuk = kasur_empuk.getKamar().ToList();
            List<Travelancar.hotel_mawar_melati_service.kamar> kamarMawarMelati = mawar_melati.getKamar().ToList();
            List<KamarAll> daftarKasurEmpuk = new List<KamarAll>();
            foreach (var k in kamarKasurEmpuk)
            {
                KamarAll kamar = new KamarAll();
                kamar.harga_akhir_pekan = k.harga_akhir_pekan;
                kamar.harga_hari_biasa = k.harga_hari_biasa;
                kamar.id = k.id;
                kamar.jumlah_guest = k.jumlah_guest;
                kamar.jumlah_tersedia = k.jumlah_tersedia;
                kamar.kategori = k.kategori;
                daftarKasurEmpuk.Add(kamar);

            }

            List<KamarAll> daftarMawarMelati = new List<KamarAll>();
            foreach (var k in kamarMawarMelati)
            {
                KamarAll kamar = new KamarAll();
                kamar.harga_akhir_pekan = k.harga_akhir_pekan;
                kamar.harga_hari_biasa = k.harga_hari_biasa;
                kamar.id = k.id;
                kamar.jumlah_guest = k.jumlah_guest;
                kamar.jumlah_tersedia = k.jumlah_tersedia;
                kamar.kategori = k.kategori;
                daftarMawarMelati.Add(kamar);

            }
            perbandinganhotel banding = new perbandinganhotel();
            banding.daftarKamarHotelKasurEmpuk = daftarKasurEmpuk;
            banding.daftarKamarHotelMawarMelati = daftarMawarMelati;

            return View(banding);
        }

        public ActionResult DaftarHotel()
        {
            List<Travelancar.hotel_kasur_empuk_service.pemesanan> pesanKasurEmpuk = kasur_empuk.getPemesanan(User.Identity.Name).ToList();
            List<Travelancar.hotel_mawar_melati_service.pemesanan> pesanMawarMelati = mawar_melati.getPemesanan(User.Identity.Name).ToList();
            List<PemesananAll> daftarPesan = new List<PemesananAll>();
            foreach (var p in pesanKasurEmpuk)
            {
                PemesananAll pesan = new PemesananAll();
                pesan.id = p.id;
                pesan.id_kamar = p.id_kamar;
                pesan.kode_booking = p.kode_booking;
                pesan.tanggal_booking = p.tanggal_booking;
                pesan.tanggal_check_in = p.tanggal_check_in;
                pesan.tanggal_check_out = p.tanggal_check_out;
                pesan.total_harga = p.total_harga;
                pesan.nama_hotel = "Kasur Empuk";
                daftarPesan.Add(pesan);
            }
            foreach (var p in pesanMawarMelati)
            {
                PemesananAll pesan = new PemesananAll();
                pesan.id = p.id;
                pesan.id_kamar = p.id_kamar;
                pesan.kode_booking = p.kode_booking;
                pesan.tanggal_booking = p.tanggal_booking;
                pesan.tanggal_check_in = p.tanggal_check_in;
                pesan.tanggal_check_out = p.tanggal_check_out;
                pesan.total_harga = p.total_harga;
                pesan.nama_hotel = "Mawar Melati";
                daftarPesan.Add(pesan);
            }
            daftarPesan = daftarPesan.OrderByDescending(p => p.tanggal_booking).ToList();
            return View("daftarpesanhotel", daftarPesan);
        }

        public ActionResult BookingKamar(int id, string hotel)
        {
            ViewBag.Id = id;
            ViewBag.Hotel = hotel;
            BookingKamar book = new BookingKamar();
            book.tanggalCheckIn = DateTime.Now;
            book.tanggalCheckOut = DateTime.Now.AddDays(1);
            book.idKamar = id;
            book.namaHotel = hotel;
            return View(book);
        }

        [HttpPost]
        public ActionResult BookingKamar(BookingKamar book)
        {
            string user = User.Identity.Name;
            if (book.namaHotel == "hotel_kasur_empuk")
            {
                Travelancar.hotel_kasur_empuk_service.CompositeType respon = kasur_empuk.booking(book.tanggalCheckIn, book.tanggalCheckOut, user, book.idKamar);
                ViewBag.Kode = respon.kodeBooking;
            }
            else
            {
                Travelancar.hotel_mawar_melati_service.CompositeType respon = mawar_melati.booking(book.tanggalCheckIn, book.tanggalCheckOut, user, book.idKamar);
                ViewBag.Kode = respon.kodeBooking;
            }
            return View("pesanbookingkamar", new BookingKamar());
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