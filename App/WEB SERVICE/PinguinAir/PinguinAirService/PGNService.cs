using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PinguinAir;
using PinguinAirLogic;

namespace PinguinAirService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PGNService : IPGNService
    {
        PGNlogic palogic = new PGNlogic();

        public PinguinAirBDO GetProduct(int id)
        {
            PinguinAirBDO productBDO = null;
            try
            {
                PinguinAir.PinguinAirBDO pinguinAirBDO = palogic.GetProduct(id);
                productBDO = pinguinAirBDO;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string reason = "GetProduct Exception";
<<<<<<< HEAD
                //throw new FaultException<ProductFault>(new ProductFault(msg), reason);
=======
>>>>>>> 55665f3b14674528ebaef40274f37dad7f8c1f03
            }
            if (productBDO == null)
            {
                string msg =
                string.Format("No product found for id {0}",
                id);
                string reason = "GetProduct Empty Product";
<<<<<<< HEAD
               // throw new FaultException<ProductFault>(new ProductFault(msg), reason);
=======
>>>>>>> 55665f3b14674528ebaef40274f37dad7f8c1f03
            }
            PinguinAirBDO flight = new PinguinAirBDO();
            TranslateProductBDOToProductDTO(productBDO, flight);
            return flight;

        }
        private void TranslateProductBDOToProductDTO(PinguinAirBDO productBDO, PinguinAirBDO flight)
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
