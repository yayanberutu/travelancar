using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuyuhAir
{
    public class PuyuhAirBDO
    {
       public int id_penerbangan { get; set; }
       public string nama_maskapai { get; set; }
        public string  kota_asal { get; set; }
        public string kota_tujuan { get; set; }
        public DateTime tanggal_keberangkatan { get; set; }
        public string jam_keberangkatan { get; set; }
        public int harga { get; set; }


        public PuyuhAirBDO GetProduct(int id)
        {
            PuyuhAirBDO productBDO = null;
            using (var PAEntities = new puyuh_airEntities())
            {
                penerbangan product = (from p in PAEntities.penerbangan
                                   where p.id_penerbangan == id
                                   select p).FirstOrDefault();
                if (product != null)
                    productBDO = new PuyuhAirBDO()
                    {
                        id_penerbangan = product.id_penerbangan,
                        nama_maskapai = product.nama_maskapai,
                        kota_asal = product.kota_asal,
                        kota_tujuan = product.kota_tujuan,
                        tanggal_keberangkatan = product.tanggal_keberangkatan,
                        jam_keberangkatan = product.jam_keberangkatan,
                        harga = product.harga
                  };
            }
            return productBDO;
        }
       
    }
}
