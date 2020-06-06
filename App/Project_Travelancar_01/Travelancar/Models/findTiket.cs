using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelancar.Models
{
    public class findTiket
    {
        
            [Required]
            public string kotaAsal { get; set; }
            [Required]
            public string kotaTujuan { get; set; }
            [Required]
            public DateTime tanggalBerangkat { get; set; }
            [Required]
            public int jumlahPenumpang { get; set; }
        
    }
}