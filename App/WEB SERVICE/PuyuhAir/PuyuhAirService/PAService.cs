using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PuyuhAir;
using PuyuhAirLogic;

namespace PuyuhAirService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PAService : IPAService
    {
        private const string Reason = "GetProduct Exception";
        PALogic productLogic = new PALogic();

        public Product GetProduct(int id)
        {
            PuyuhAirBDO productBDO = null;

            productBDO = productLogic.GetProduct(id);

            Product product = new Product();
            TranslateProductBDOToProductDTO(productBDO, product);
            return product;

        }
        private void TranslateProductBDOToProductDTO(PuyuhAirBDO productBDO, Product flight)
        {
            flight.id_penerbangan = productBDO.id_penerbangan;
            flight.nama_maskapai = productBDO.nama_maskapai;
            flight.kota_asal = productBDO.kota_asal;
            flight.kota_tujuan = productBDO.kota_tujuan;
            flight.tanggal_keberangkatan = productBDO.tanggal_keberangkatan;
            flight.jam_keberangkatan = productBDO.jam_keberangkatan;
            flight.harga = productBDO.harga;
        }
    }
    
}
