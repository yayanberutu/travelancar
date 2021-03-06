﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PinguinAir
{
    public class Service1 : IService1
    {
        public int Bayar(int id_tiket)
        {
            pingiun_airEntities entity = new pingiun_airEntities();

            tiket tkt = entity.tiket.Find(id_tiket);
            tkt.STATUS = "Lunas";
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            tkt.kode_booking = path;
            entity.SaveChanges();
            return 1;
        }

        public int Booking(int no_pesawat, List<penumpang> penumpangs, int user_id)
        {
            pingiun_airEntities entity = new pingiun_airEntities();
            tiket tkt = new tiket();
            tkt.id_penerbangan = no_pesawat;
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            tkt.kode_bayar = path;
            tkt.kode_booking = "NULL";
            tkt.STATUS = "Belum Bayar";
            tkt.user_id = user_id;
            tkt.waktu_booking = DateTime.Now;
            tkt.batas_waktu_bayar_atm = DateTime.Now.AddMinutes(60);
            tkt.batas_waktu_bayar_internet_banking = DateTime.Now.AddMinutes(30);

            penerbangan p = entity.penerbangan.Find(no_pesawat);
            tkt.total_harga = penumpangs.Count() * p.harga;
            entity.tiket.Add(tkt);
            entity.SaveChanges();

            penumpang pn;
            foreach (var a in penumpangs)
            {
                pn = new penumpang();
                pn.id_tiket = tkt.id_tiket;
                pn.nama = a.nama;
                pn.nomor_identitas = a.nomor_identitas;
                entity.penumpang.Add(pn);
                entity.SaveChanges();
            }
            return 0;
        }

        public List<tiket> GetPemesanan(int user_id)
        {
            List<tiket> tikets = new List<tiket>();
            tiket tmp = new tiket();
            pingiun_airEntities entity = new pingiun_airEntities();
            IEnumerable<tiket> daftar = from t in entity.tiket
                                        where t.user_id == user_id
                                        select t;
            if (daftar.Count() == 0)
            {
                tiket a = new tiket();
                a.kode_bayar = "NULL";
                tikets.Add(a);
                return tikets;
            }
            foreach (var k in daftar)
            {
                tiket tk = new tiket();
                tk.id_tiket = k.id_tiket;
                tk.id_penerbangan = k.id_penerbangan;
                tk.kode_bayar = k.kode_bayar;
                tk.kode_booking = k.kode_booking;
                tk.STATUS = k.STATUS;
                tk.total_harga = k.total_harga;
                tk.user_id = k.user_id;
                tk.waktu_booking = k.waktu_booking;
                tk.batas_waktu_bayar_atm = k.batas_waktu_bayar_atm;
                tk.batas_waktu_bayar_internet_banking = k.batas_waktu_bayar_internet_banking;
                tikets.Add(tk);
            }
            return tikets;
        }

        public List<penerbangan> GetPenerbangan(string kota_asal, string kota_tujuan, DateTime tgl_berangkat)
        {
            List<penerbangan> penerbangans = new List<penerbangan>();
            penerbangan tmp = new penerbangan();

            pingiun_airEntities entity = new pingiun_airEntities();

            IEnumerable<penerbangan> daftar = (from p in entity.penerbangan
                                               where ((p.kota_asal == kota_asal) && (p.kota_tujuan == kota_tujuan) && p.tanggal_keberangkatan == tgl_berangkat)
                                               select p);
            if (daftar.Count() == 0)
            {
                penerbangan a = new penerbangan();
                a.kota_asal = "NULL";
                penerbangans.Add(a);
                return penerbangans;
            }
            foreach (var k in daftar)
            {
                penerbangan pr = new penerbangan();
                pr.id_penerbangan = k.id_penerbangan;
                pr.harga = k.harga;
                pr.jam_keberangkatan = k.jam_keberangkatan;
                pr.kota_asal = k.kota_asal;
                pr.kota_tujuan = k.kota_tujuan;
                pr.nama_maskapai = k.nama_maskapai;
                pr.tanggal_keberangkatan = k.tanggal_keberangkatan;
                penerbangans.Add(pr);
            }
            return penerbangans;
        }

        public CompositeType GetTiket(int id_tiket)
        {
            pingiun_airEntities entity = new pingiun_airEntities();
            //tiket
            var tik = (from u in entity.tiket
                       where u.id_tiket == id_tiket
                       select u).FirstOrDefault();
            tiket t = new tiket();
            t.batas_waktu_bayar_atm = tik.batas_waktu_bayar_atm;
            t.batas_waktu_bayar_internet_banking = t.batas_waktu_bayar_internet_banking;
            t.id_tiket = tik.id_tiket;
            t.id_penerbangan = tik.id_penerbangan;
            t.kode_bayar = tik.kode_bayar;
            t.kode_booking = tik.kode_booking;
            t.STATUS = tik.STATUS;
            t.user_id = tik.user_id;
            t.waktu_booking = tik.waktu_booking;
            t.total_harga = tik.total_harga;

            IEnumerable<penumpang> daftarPenumpang = from p in entity.penumpang
                                                     where p.id_penumpang == id_tiket
                                                     select p;
            penumpang pn;
            List<penumpang> penumpangs = new List<penumpang>();
            foreach (var a in daftarPenumpang)
            {
                pn = new penumpang();
                pn.id_tiket = id_tiket;
                pn.nama = a.nama;
                pn.nomor_identitas = a.nomor_identitas;
                penumpangs.Add(pn);
            }

            //penerbangan
            penerbangan k = entity.penerbangan.Find(t.id_penerbangan);
            penerbangan pr = new penerbangan();
            pr.id_penerbangan = k.id_penerbangan;
            pr.harga = k.harga;
            pr.jam_keberangkatan = k.jam_keberangkatan;
            pr.kota_asal = k.kota_asal;
            pr.kota_tujuan = k.kota_tujuan;
            pr.nama_maskapai = k.nama_maskapai;


            CompositeType composit = new CompositeType();
            composit.penerbangan_sah = pr;
            composit.tiket_sah = t;
            composit.daftarPenumpang = penumpangs;

            return composit;
        }
    }
}
