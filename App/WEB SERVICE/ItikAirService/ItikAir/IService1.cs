using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ItikAir
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<penerbangan> GetPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tgl_berangkat);

        [OperationContract]
        int Bayar(int id_tiket);

        [OperationContract]
        CompositeType GetTiket(int id_tiket);

        [OperationContract]
        int Booking(int id_penerbangan, List<penumpang> penumpangs, int user_id);

        [OperationContract]
        List<tiket> GetPemesanan(int user_id);
       
    }

    [DataContract]
    public class CompositeType
    {
        [DataMember]
        public penerbangan penerbangan_sah;

        [DataMember]
        public tiket tiket_sah;

        [DataMember]
        public List<penumpang> daftarPenumpang;

    }
}
