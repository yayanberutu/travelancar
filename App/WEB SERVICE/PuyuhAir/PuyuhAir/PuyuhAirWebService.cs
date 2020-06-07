using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace PuyuhAir
{
    [ServiceContract]
    public interface PuyuhAirWebService
    {
        [OperationContract]
        IEnumerable<Pesawat> GetPenerbangan();
        [OperationContract]
        void InsertPenerbangan(Pesawat penerbangan);
        [OperationContract]
        void UpdatePenerbangan(Pesawat penerbangan);
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
    public class CompositeType
    {
        [DataMember]
        public penerbangan penerbangan_sah;

        [DataMember]
        public tiket tiket_sah;

        [DataMember]
        public List<penumpang> daftarPenumpang;

    }
    [DataContract]
    public class Pesawat
    {
        [Key]
        [Required]
        [DataMember]
        public int id_penerbangan { get; set; }
        [Required]
        [DataMember]
        public string nama_maskapai { get; set; }
        [Required]
        [DataMember]
        public string kota_asal { get; set; }
        [Required]
        [DataMember]
        public string kota_tujuan { get; set; }
        [Required]
        [DataMember]
        public DateTime tanggal_keberangkatan { get; set; }
        [Required]
        [DataMember]
        public string jam_keberangkatan { get; set; }
        [Required]
        [DataMember]
        public int harga { get; set; }
    }
}
