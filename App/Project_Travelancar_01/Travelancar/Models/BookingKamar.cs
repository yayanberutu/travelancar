using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelancar.Models
{
    public class BookingKamar
    {
        public int idKamar { get; set; }
        public string namaHotel { get; set; }
        [Required]
        public DateTime tanggalCheckIn { get; set; }
        [Required]
        public DateTime tanggalCheckOut { get; set; }

        public BookingKamar()
        {
            this.idKamar = 0;
            this.namaHotel = "NULL";
        }
    }
}