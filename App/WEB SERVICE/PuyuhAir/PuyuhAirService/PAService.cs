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
        PALogic palogic = new PALogic();

        public PuyuhAirBDO GetProduct(int id)
        {
            PuyuhAirBDO productBDO = null;
            try
            {
                PuyuhAir.PuyuhAirBDO puyuhAirBDO = palogic.GetProduct(id);
                productBDO = puyuhAirBDO;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string reason = "GetProduct Exception";
                throw new FaultException<ProductFault>(new ProductFault(msg), reason);
            }
            if (productBDO == null)
            {
                string msg =
                string.Format("No product found for id {0}",
                id);
                string reason = "GetProduct Empty Product";
                throw new FaultException<ProductFault>(new ProductFault(msg), reason);
            }
            PuyuhAirBDO flight = new PuyuhAirBDO();
            TranslateProductBDOToProductDTO(productBDO, flight);
            return flight;

        }
        private void TranslateProductBDOToProductDTO(PuyuhAirBDO productBDO, PuyuhAirBDO flight)
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
