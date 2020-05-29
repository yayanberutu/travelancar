using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomainObject
{
    public class PembayaranBDO
    {
        public string invoice_number { get; set; }
        public DateTime waktu_pesan { get; set; }
        public DateTime waktu_bayar { get; set; }
        public double nominal { get; set; }
        public int status_bayar { get; set; }

        public PembayaranBDO Bayar(string invoiceNumber)
        {
            PembayaranBDO pembayaran = null;
            return pembayaran;
        }
    }
}
