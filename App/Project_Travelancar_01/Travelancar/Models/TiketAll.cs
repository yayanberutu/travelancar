﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travelancar.Models
{
    public class TiketAll
    {
        public int id_tiket { get; set; }
        public int id_penerbangan { get; set; }
        public string kode_booking { get; set; }
        public Nullable<System.DateTime> waktu_booking { get; set; }
        public Nullable<System.DateTime> batas_waktu_bayar_atm { get; set; }
        public Nullable<System.DateTime> batas_waktu_bayar_internet_banking { get; set; }
        public string kode_bayar { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<long> total_harga { get; set; }
    }
}