using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceInterfaceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        [FaultContract(typeof(HotelMawarMelatiFault))]
        IEnumerable<Kamar> getAllKamar();

        [OperationContract]
        [FaultContract(typeof(HotelMawarMelatiFault))]
        void InsertBooking(Booking booking, Kamar kmr);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceInterfaceLayer.ContractType".
    [DataContract]
    public class Kamar
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string no_kamar { get; set; }
        [DataMember]
        public double harga_akhir_pekan { get; set; }
        [DataMember]
        public double harga_biasa { get; set; }
        [DataMember]
        public int kapasitas { get; set; }
        [DataMember]
        public string fasilitas { get; set; }
        [DataMember]
        public int status { get; set; }
    }
    [DataContract]
    public class Booking
    {
        [DataMember]
        public string kode_booking { get; set; }
        [DataMember]
        public string id_user { get; set; }
        [DataMember]
        public DateTime tanggal_booking { get; set; }
        [DataMember]
        public DateTime tanggal_mulai { get; set; }
        [DataMember]
        public DateTime tanggal_selesai { get; set; }
    }

    [DataContract]
    public class BookingHistory
    {
        [DataMember]
        public string kode_booking;
        [DataMember]
        public string id_kamar;
    }

    [DataContract]
    public class HotelMawarMelatiFault
    {
        public HotelMawarMelatiFault(string msg)
        {
            FaultMessage = msg;
        }
        [DataMember]
        public string FaultMessage;
    }
}
