using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PinguinAir
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Penerbangan> GetPinguinAir();
        [OperationContract]
        void InsertPenerbangan(Penerbangan pboj);
        [OperationContract]
        void UpdatePenerbangan(Penerbangan pboj);
        [OperationContract]
        void DeletePenerbangan(int id);
        [OperationContract]
        List<penerbangan> getPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tanggal_keberangkatan);

        [OperationContract]
        int bayar(int id_tiket);

        [OperationContract]
        int booking(int id_penerbangan, List<penumpang> penumpangs, int user_id);

        [OperationContract]
        CompositeType getTiket(int id_tiket);

        [OperationContract]
        List<tiket> getPemesanan(int user_id);

    }
    [DataContract]
    public class Penerbangan
    {
        [DataMember]
        [Key]
        [Required]
        public int id_penerbangan { get; set; }
        [DataMember]
        [Required]
        public string nama_maskapai { get; set; }
        [DataMember]
        [Required]
        public string kota_asal { get; set; }
        [DataMember]
        [Required]
        public string kota_tujuan { get; set; }
        [DataMember]
        [Required]
        public DateTime tanggal_keberangkatan { get; set; }
        [DataMember]
        [Required]
        public string jam_keberangkatan { get; set; }
        [DataMember]
        [Required]
        public int harga { get; set; }
    }
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
