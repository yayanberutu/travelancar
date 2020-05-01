using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PenerbanganModel
    {

        public string no_pesawat { get; set; }
        public string bandara_asal { get; set; }
        public string bandara_tujuan { get; set; }
        public DateTime tgl_berangkat { get; set; }
        public DateTime tgl_tiba { get; set; }
        public TimeSpan jam_berangkat { get; set; }
        public TimeSpan jam_tiba { get; set; }
    }
}