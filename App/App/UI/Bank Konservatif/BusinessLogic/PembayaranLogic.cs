using BusinessDomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PembayaranLogic
    {
        PembayaranBDO objBayar = new PembayaranBDO();
        public PembayaranBDO getPembayaran(string invoiceNumber)
        {
            return objBayar.getPembayaran(invoiceNumber);

        }

        public bool doPembayaran(ref PembayaranBDO objBayar, double saldo, string message)
        {

            var pembayaranInDB = getPembayaran(objBayar.invoice_number);
            if(pembayaranInDB == null)
            {
                message = "pembayaran tidak ditemukan!";
                return false;
            }
            if(objBayar.nominal > saldo)
            {
                message = "saldo tidak mencukupi";
                return false;
            }
            else
            {
                return 
            }
        }
    }
}
