using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
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

        public PembayaranBDO getPembayaran(string invoiceNumber)
        {
            PembayaranBDO objPembayaran = null;
            using(var BayarEntities = new BankKonservatifEntities())
            {
                Pembayaran objBayar = (from p in BayarEntities.Pembayarans
                                       where p.invoice_number == invoice_number
                                       select p).FirstOrDefault();

                if (objBayar != null)
                    objPembayaran = new PembayaranBDO
                    {
                        invoice_number = objBayar.invoice_number,
                        waktu_pesan = objBayar.waktu_pemesanan,
                        waktu_bayar = (DateTime) objBayar.waktu_pembayaran,
                        nominal = objBayar.nominal,
                        status_bayar = objBayar.status_bayar
                    };
            }
            return objPembayaran;
        }

        public bool doPembayaran(ref PembayaranBDO objBayar, double saldo, ref string message) {
            bool status = false;
            using(var BayarEntities = new BankKonservatifEntities())
            {
                if(saldo < objBayar.nominal)
                {
                    return status;
                } 
                else
                {
                    status = true;
                    string in_num = objBayar.invoice_number; //in: invoice number
                    Pembayaran objInDB = (from p in BayarEntities.Pembayarans
                                          where p.invoice_number == in_num
                                          select p).FirstOrDefault();
                    objInDB.status_bayar = 1;
                    BayarEntities.Pembayarans.AddOrUpdate(objInDB);
                    BayarEntities.SaveChanges();
                }
            }
            message = "pembayaran berhasil dilakukan!";
            return status;
        }
    }
}
