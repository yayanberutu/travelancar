using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travelancar.Models
{
    public class PenerbanganAll
    {
        public int id_penerbangan { get; set; }
        public string nama_maskapai { get; set; }
        public string kota_asal { get; set; }
        public string kota_tujuan { get; set; }
        public System.DateTime tanggal_keberangkatan { get; set; }
        public string jam_keberangkatan { get; set; }
        public int harga { get; set; }

    }
}