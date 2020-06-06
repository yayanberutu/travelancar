﻿using PuyuhAir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace PuyuhAirService
{
    public interface IPAService
    {
        [OperationContract]
        [FaultContract(typeof(ProductFault))]
        Product GetProduct(int id);


    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int id_penerbangan { get; set; }

        [DataMember]
        public string nama_maskapai { get; set; }

        [DataMember]
        public string kota_asal { get; set; }

        [DataMember]
        public string kota_tujuan { get; set; }

        [DataMember]
        public DateTime tanggal_keberangkatan { get; set; }

        [DataMember]
        public string jam_keberangkatan { get; set; }

        [DataMember]
        public int harga { get; set; }

    }


    [DataContract]
    public class ProductFault
    {
        public ProductFault(string msg)
        {
            FaultMessage = msg;
        }
        [DataMember]
        public string FaultMessage;
    }
}