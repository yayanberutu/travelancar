﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travelancar.maskapai_piguin_air_service {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Penerbangan", Namespace="http://schemas.datacontract.org/2004/07/PinguinAir")]
    [System.SerializableAttribute()]
    public partial class Penerbangan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int hargaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_penerbanganField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jam_keberangkatanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kota_asalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kota_tujuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nama_maskapaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime tanggal_keberangkatanField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int harga {
            get {
                return this.hargaField;
            }
            set {
                if ((this.hargaField.Equals(value) != true)) {
                    this.hargaField = value;
                    this.RaisePropertyChanged("harga");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_penerbangan {
            get {
                return this.id_penerbanganField;
            }
            set {
                if ((this.id_penerbanganField.Equals(value) != true)) {
                    this.id_penerbanganField = value;
                    this.RaisePropertyChanged("id_penerbangan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jam_keberangkatan {
            get {
                return this.jam_keberangkatanField;
            }
            set {
                if ((object.ReferenceEquals(this.jam_keberangkatanField, value) != true)) {
                    this.jam_keberangkatanField = value;
                    this.RaisePropertyChanged("jam_keberangkatan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kota_asal {
            get {
                return this.kota_asalField;
            }
            set {
                if ((object.ReferenceEquals(this.kota_asalField, value) != true)) {
                    this.kota_asalField = value;
                    this.RaisePropertyChanged("kota_asal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kota_tujuan {
            get {
                return this.kota_tujuanField;
            }
            set {
                if ((object.ReferenceEquals(this.kota_tujuanField, value) != true)) {
                    this.kota_tujuanField = value;
                    this.RaisePropertyChanged("kota_tujuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama_maskapai {
            get {
                return this.nama_maskapaiField;
            }
            set {
                if ((object.ReferenceEquals(this.nama_maskapaiField, value) != true)) {
                    this.nama_maskapaiField = value;
                    this.RaisePropertyChanged("nama_maskapai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime tanggal_keberangkatan {
            get {
                return this.tanggal_keberangkatanField;
            }
            set {
                if ((this.tanggal_keberangkatanField.Equals(value) != true)) {
                    this.tanggal_keberangkatanField = value;
                    this.RaisePropertyChanged("tanggal_keberangkatan");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="penerbangan", Namespace="http://schemas.datacontract.org/2004/07/PinguinAir")]
    [System.SerializableAttribute()]
    public partial class penerbangan1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int hargaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_penerbanganField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jam_keberangkatanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kota_asalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kota_tujuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nama_maskapaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime tanggal_keberangkatanField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int harga {
            get {
                return this.hargaField;
            }
            set {
                if ((this.hargaField.Equals(value) != true)) {
                    this.hargaField = value;
                    this.RaisePropertyChanged("harga");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_penerbangan {
            get {
                return this.id_penerbanganField;
            }
            set {
                if ((this.id_penerbanganField.Equals(value) != true)) {
                    this.id_penerbanganField = value;
                    this.RaisePropertyChanged("id_penerbangan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jam_keberangkatan {
            get {
                return this.jam_keberangkatanField;
            }
            set {
                if ((object.ReferenceEquals(this.jam_keberangkatanField, value) != true)) {
                    this.jam_keberangkatanField = value;
                    this.RaisePropertyChanged("jam_keberangkatan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kota_asal {
            get {
                return this.kota_asalField;
            }
            set {
                if ((object.ReferenceEquals(this.kota_asalField, value) != true)) {
                    this.kota_asalField = value;
                    this.RaisePropertyChanged("kota_asal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kota_tujuan {
            get {
                return this.kota_tujuanField;
            }
            set {
                if ((object.ReferenceEquals(this.kota_tujuanField, value) != true)) {
                    this.kota_tujuanField = value;
                    this.RaisePropertyChanged("kota_tujuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama_maskapai {
            get {
                return this.nama_maskapaiField;
            }
            set {
                if ((object.ReferenceEquals(this.nama_maskapaiField, value) != true)) {
                    this.nama_maskapaiField = value;
                    this.RaisePropertyChanged("nama_maskapai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime tanggal_keberangkatan {
            get {
                return this.tanggal_keberangkatanField;
            }
            set {
                if ((this.tanggal_keberangkatanField.Equals(value) != true)) {
                    this.tanggal_keberangkatanField = value;
                    this.RaisePropertyChanged("tanggal_keberangkatan");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="penumpang", Namespace="http://schemas.datacontract.org/2004/07/PinguinAir")]
    [System.SerializableAttribute()]
    public partial class penumpang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_penumpangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tiketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomor_identitasField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_penumpang {
            get {
                return this.id_penumpangField;
            }
            set {
                if ((this.id_penumpangField.Equals(value) != true)) {
                    this.id_penumpangField = value;
                    this.RaisePropertyChanged("id_penumpang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tiket {
            get {
                return this.id_tiketField;
            }
            set {
                if ((this.id_tiketField.Equals(value) != true)) {
                    this.id_tiketField = value;
                    this.RaisePropertyChanged("id_tiket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama {
            get {
                return this.namaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaField, value) != true)) {
                    this.namaField = value;
                    this.RaisePropertyChanged("nama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomor_identitas {
            get {
                return this.nomor_identitasField;
            }
            set {
                if ((object.ReferenceEquals(this.nomor_identitasField, value) != true)) {
                    this.nomor_identitasField = value;
                    this.RaisePropertyChanged("nomor_identitas");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/PinguinAir")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.maskapai_piguin_air_service.penumpang[] daftarPenumpangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.maskapai_piguin_air_service.penerbangan1 penerbangan_sahField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.maskapai_piguin_air_service.tiket tiket_sahField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Travelancar.maskapai_piguin_air_service.penumpang[] daftarPenumpang {
            get {
                return this.daftarPenumpangField;
            }
            set {
                if ((object.ReferenceEquals(this.daftarPenumpangField, value) != true)) {
                    this.daftarPenumpangField = value;
                    this.RaisePropertyChanged("daftarPenumpang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Travelancar.maskapai_piguin_air_service.penerbangan1 penerbangan_sah {
            get {
                return this.penerbangan_sahField;
            }
            set {
                if ((object.ReferenceEquals(this.penerbangan_sahField, value) != true)) {
                    this.penerbangan_sahField = value;
                    this.RaisePropertyChanged("penerbangan_sah");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Travelancar.maskapai_piguin_air_service.tiket tiket_sah {
            get {
                return this.tiket_sahField;
            }
            set {
                if ((object.ReferenceEquals(this.tiket_sahField, value) != true)) {
                    this.tiket_sahField = value;
                    this.RaisePropertyChanged("tiket_sah");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tiket", Namespace="http://schemas.datacontract.org/2004/07/PinguinAir")]
    [System.SerializableAttribute()]
    public partial class tiket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string STATUSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> batas_waktu_bayar_atmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> batas_waktu_bayar_internet_bankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_penerbanganField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_tiketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kode_bayarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kode_bookingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> total_hargaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> user_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> waktu_bookingField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string STATUS {
            get {
                return this.STATUSField;
            }
            set {
                if ((object.ReferenceEquals(this.STATUSField, value) != true)) {
                    this.STATUSField = value;
                    this.RaisePropertyChanged("STATUS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> batas_waktu_bayar_atm {
            get {
                return this.batas_waktu_bayar_atmField;
            }
            set {
                if ((this.batas_waktu_bayar_atmField.Equals(value) != true)) {
                    this.batas_waktu_bayar_atmField = value;
                    this.RaisePropertyChanged("batas_waktu_bayar_atm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> batas_waktu_bayar_internet_banking {
            get {
                return this.batas_waktu_bayar_internet_bankingField;
            }
            set {
                if ((this.batas_waktu_bayar_internet_bankingField.Equals(value) != true)) {
                    this.batas_waktu_bayar_internet_bankingField = value;
                    this.RaisePropertyChanged("batas_waktu_bayar_internet_banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_penerbangan {
            get {
                return this.id_penerbanganField;
            }
            set {
                if ((this.id_penerbanganField.Equals(value) != true)) {
                    this.id_penerbanganField = value;
                    this.RaisePropertyChanged("id_penerbangan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_tiket {
            get {
                return this.id_tiketField;
            }
            set {
                if ((this.id_tiketField.Equals(value) != true)) {
                    this.id_tiketField = value;
                    this.RaisePropertyChanged("id_tiket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kode_bayar {
            get {
                return this.kode_bayarField;
            }
            set {
                if ((object.ReferenceEquals(this.kode_bayarField, value) != true)) {
                    this.kode_bayarField = value;
                    this.RaisePropertyChanged("kode_bayar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kode_booking {
            get {
                return this.kode_bookingField;
            }
            set {
                if ((object.ReferenceEquals(this.kode_bookingField, value) != true)) {
                    this.kode_bookingField = value;
                    this.RaisePropertyChanged("kode_booking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> total_harga {
            get {
                return this.total_hargaField;
            }
            set {
                if ((this.total_hargaField.Equals(value) != true)) {
                    this.total_hargaField = value;
                    this.RaisePropertyChanged("total_harga");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> user_id {
            get {
                return this.user_idField;
            }
            set {
                if ((this.user_idField.Equals(value) != true)) {
                    this.user_idField = value;
                    this.RaisePropertyChanged("user_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> waktu_booking {
            get {
                return this.waktu_bookingField;
            }
            set {
                if ((this.waktu_bookingField.Equals(value) != true)) {
                    this.waktu_bookingField = value;
                    this.RaisePropertyChanged("waktu_booking");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="maskapai_piguin_air_service.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPinguinAir", ReplyAction="http://tempuri.org/IService1/GetPinguinAirResponse")]
        Travelancar.maskapai_piguin_air_service.Penerbangan[] GetPinguinAir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPinguinAir", ReplyAction="http://tempuri.org/IService1/GetPinguinAirResponse")]
        System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.Penerbangan[]> GetPinguinAirAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPenerbangan", ReplyAction="http://tempuri.org/IService1/InsertPenerbanganResponse")]
        void InsertPenerbangan(Travelancar.maskapai_piguin_air_service.Penerbangan pboj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPenerbangan", ReplyAction="http://tempuri.org/IService1/InsertPenerbanganResponse")]
        System.Threading.Tasks.Task InsertPenerbanganAsync(Travelancar.maskapai_piguin_air_service.Penerbangan pboj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePenerbangan", ReplyAction="http://tempuri.org/IService1/UpdatePenerbanganResponse")]
        void UpdatePenerbangan(Travelancar.maskapai_piguin_air_service.Penerbangan pboj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdatePenerbangan", ReplyAction="http://tempuri.org/IService1/UpdatePenerbanganResponse")]
        System.Threading.Tasks.Task UpdatePenerbanganAsync(Travelancar.maskapai_piguin_air_service.Penerbangan pboj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePenerbangan", ReplyAction="http://tempuri.org/IService1/DeletePenerbanganResponse")]
        void DeletePenerbangan(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePenerbangan", ReplyAction="http://tempuri.org/IService1/DeletePenerbanganResponse")]
        System.Threading.Tasks.Task DeletePenerbanganAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPenerbangan", ReplyAction="http://tempuri.org/IService1/getPenerbanganResponse")]
        Travelancar.maskapai_piguin_air_service.penerbangan1[] getPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tanggal_keberangkatan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPenerbangan", ReplyAction="http://tempuri.org/IService1/getPenerbanganResponse")]
        System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.penerbangan1[]> getPenerbanganAsync(string kota_asal, string kota_tujuan, System.DateTime tanggal_keberangkatan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bayar", ReplyAction="http://tempuri.org/IService1/bayarResponse")]
        int bayar(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/bayar", ReplyAction="http://tempuri.org/IService1/bayarResponse")]
        System.Threading.Tasks.Task<int> bayarAsync(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/booking", ReplyAction="http://tempuri.org/IService1/bookingResponse")]
        int booking(int id_penerbangan, Travelancar.maskapai_piguin_air_service.penumpang[] penumpangs, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/booking", ReplyAction="http://tempuri.org/IService1/bookingResponse")]
        System.Threading.Tasks.Task<int> bookingAsync(int id_penerbangan, Travelancar.maskapai_piguin_air_service.penumpang[] penumpangs, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTiket", ReplyAction="http://tempuri.org/IService1/getTiketResponse")]
        Travelancar.maskapai_piguin_air_service.CompositeType getTiket(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTiket", ReplyAction="http://tempuri.org/IService1/getTiketResponse")]
        System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.CompositeType> getTiketAsync(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPemesanan", ReplyAction="http://tempuri.org/IService1/getPemesananResponse")]
        Travelancar.maskapai_piguin_air_service.tiket[] getPemesanan(int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPemesanan", ReplyAction="http://tempuri.org/IService1/getPemesananResponse")]
        System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.tiket[]> getPemesananAsync(int user_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Travelancar.maskapai_piguin_air_service.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Travelancar.maskapai_piguin_air_service.IService1>, Travelancar.maskapai_piguin_air_service.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Travelancar.maskapai_piguin_air_service.Penerbangan[] GetPinguinAir() {
            return base.Channel.GetPinguinAir();
        }
        
        public System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.Penerbangan[]> GetPinguinAirAsync() {
            return base.Channel.GetPinguinAirAsync();
        }
        
        public void InsertPenerbangan(Travelancar.maskapai_piguin_air_service.Penerbangan pboj) {
            base.Channel.InsertPenerbangan(pboj);
        }
        
        public System.Threading.Tasks.Task InsertPenerbanganAsync(Travelancar.maskapai_piguin_air_service.Penerbangan pboj) {
            return base.Channel.InsertPenerbanganAsync(pboj);
        }
        
        public void UpdatePenerbangan(Travelancar.maskapai_piguin_air_service.Penerbangan pboj) {
            base.Channel.UpdatePenerbangan(pboj);
        }
        
        public System.Threading.Tasks.Task UpdatePenerbanganAsync(Travelancar.maskapai_piguin_air_service.Penerbangan pboj) {
            return base.Channel.UpdatePenerbanganAsync(pboj);
        }
        
        public void DeletePenerbangan(int id) {
            base.Channel.DeletePenerbangan(id);
        }
        
        public System.Threading.Tasks.Task DeletePenerbanganAsync(int id) {
            return base.Channel.DeletePenerbanganAsync(id);
        }
        
        public Travelancar.maskapai_piguin_air_service.penerbangan1[] getPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tanggal_keberangkatan) {
            return base.Channel.getPenerbangan(kota_asal, kota_tujuan, tanggal_keberangkatan);
        }
        
        public System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.penerbangan1[]> getPenerbanganAsync(string kota_asal, string kota_tujuan, System.DateTime tanggal_keberangkatan) {
            return base.Channel.getPenerbanganAsync(kota_asal, kota_tujuan, tanggal_keberangkatan);
        }
        
        public int bayar(int id_tiket) {
            return base.Channel.bayar(id_tiket);
        }
        
        public System.Threading.Tasks.Task<int> bayarAsync(int id_tiket) {
            return base.Channel.bayarAsync(id_tiket);
        }
        
        public int booking(int id_penerbangan, Travelancar.maskapai_piguin_air_service.penumpang[] penumpangs, int user_id) {
            return base.Channel.booking(id_penerbangan, penumpangs, user_id);
        }
        
        public System.Threading.Tasks.Task<int> bookingAsync(int id_penerbangan, Travelancar.maskapai_piguin_air_service.penumpang[] penumpangs, int user_id) {
            return base.Channel.bookingAsync(id_penerbangan, penumpangs, user_id);
        }
        
        public Travelancar.maskapai_piguin_air_service.CompositeType getTiket(int id_tiket) {
            return base.Channel.getTiket(id_tiket);
        }
        
        public System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.CompositeType> getTiketAsync(int id_tiket) {
            return base.Channel.getTiketAsync(id_tiket);
        }
        
        public Travelancar.maskapai_piguin_air_service.tiket[] getPemesanan(int user_id) {
            return base.Channel.getPemesanan(user_id);
        }
        
        public System.Threading.Tasks.Task<Travelancar.maskapai_piguin_air_service.tiket[]> getPemesananAsync(int user_id) {
            return base.Channel.getPemesananAsync(user_id);
        }
    }
}
