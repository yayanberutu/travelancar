﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travelancar.ItikAirService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="penerbangan", Namespace="http://schemas.datacontract.org/2004/07/ItikAir")]
    [System.SerializableAttribute()]
    public partial class penerbangan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.ItikAirService.tiket[] tiketField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Travelancar.ItikAirService.tiket[] tiket {
            get {
                return this.tiketField;
            }
            set {
                if ((object.ReferenceEquals(this.tiketField, value) != true)) {
                    this.tiketField = value;
                    this.RaisePropertyChanged("tiket");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="tiket", Namespace="http://schemas.datacontract.org/2004/07/ItikAir")]
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
        private Travelancar.ItikAirService.penerbangan penerbanganField;
        
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
        public Travelancar.ItikAirService.penerbangan penerbangan {
            get {
                return this.penerbanganField;
            }
            set {
                if ((object.ReferenceEquals(this.penerbanganField, value) != true)) {
                    this.penerbanganField = value;
                    this.RaisePropertyChanged("penerbangan");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ItikAir")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.ItikAirService.penumpang[] daftarPenumpangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.ItikAirService.penerbangan penerbangan_sahField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Travelancar.ItikAirService.tiket tiket_sahField;
        
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
        public Travelancar.ItikAirService.penumpang[] daftarPenumpang {
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
        public Travelancar.ItikAirService.penerbangan penerbangan_sah {
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
        public Travelancar.ItikAirService.tiket tiket_sah {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="penumpang", Namespace="http://schemas.datacontract.org/2004/07/ItikAir")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ItikAirService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPenerbangan", ReplyAction="http://tempuri.org/IService1/GetPenerbanganResponse")]
        Travelancar.ItikAirService.penerbangan[] GetPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tgl_berangkat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPenerbangan", ReplyAction="http://tempuri.org/IService1/GetPenerbanganResponse")]
        System.Threading.Tasks.Task<Travelancar.ItikAirService.penerbangan[]> GetPenerbanganAsync(string kota_asal, string kota_tujuan, System.DateTime tgl_berangkat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Bayar", ReplyAction="http://tempuri.org/IService1/BayarResponse")]
        int Bayar(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Bayar", ReplyAction="http://tempuri.org/IService1/BayarResponse")]
        System.Threading.Tasks.Task<int> BayarAsync(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTiket", ReplyAction="http://tempuri.org/IService1/GetTiketResponse")]
        Travelancar.ItikAirService.CompositeType GetTiket(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTiket", ReplyAction="http://tempuri.org/IService1/GetTiketResponse")]
        System.Threading.Tasks.Task<Travelancar.ItikAirService.CompositeType> GetTiketAsync(int id_tiket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Booking", ReplyAction="http://tempuri.org/IService1/BookingResponse")]
        int Booking(int id_penerbangan, Travelancar.ItikAirService.penumpang[] penumpangs, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Booking", ReplyAction="http://tempuri.org/IService1/BookingResponse")]
        System.Threading.Tasks.Task<int> BookingAsync(int id_penerbangan, Travelancar.ItikAirService.penumpang[] penumpangs, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPemesanan", ReplyAction="http://tempuri.org/IService1/GetPemesananResponse")]
        Travelancar.ItikAirService.tiket[] GetPemesanan(int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPemesanan", ReplyAction="http://tempuri.org/IService1/GetPemesananResponse")]
        System.Threading.Tasks.Task<Travelancar.ItikAirService.tiket[]> GetPemesananAsync(int user_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Travelancar.ItikAirService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Travelancar.ItikAirService.IService1>, Travelancar.ItikAirService.IService1 {
        
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
        
        public Travelancar.ItikAirService.penerbangan[] GetPenerbangan(string kota_asal, string kota_tujuan, System.DateTime tgl_berangkat) {
            return base.Channel.GetPenerbangan(kota_asal, kota_tujuan, tgl_berangkat);
        }
        
        public System.Threading.Tasks.Task<Travelancar.ItikAirService.penerbangan[]> GetPenerbanganAsync(string kota_asal, string kota_tujuan, System.DateTime tgl_berangkat) {
            return base.Channel.GetPenerbanganAsync(kota_asal, kota_tujuan, tgl_berangkat);
        }
        
        public int Bayar(int id_tiket) {
            return base.Channel.Bayar(id_tiket);
        }
        
        public System.Threading.Tasks.Task<int> BayarAsync(int id_tiket) {
            return base.Channel.BayarAsync(id_tiket);
        }
        
        public Travelancar.ItikAirService.CompositeType GetTiket(int id_tiket) {
            return base.Channel.GetTiket(id_tiket);
        }
        
        public System.Threading.Tasks.Task<Travelancar.ItikAirService.CompositeType> GetTiketAsync(int id_tiket) {
            return base.Channel.GetTiketAsync(id_tiket);
        }
        
        public int Booking(int id_penerbangan, Travelancar.ItikAirService.penumpang[] penumpangs, int user_id) {
            return base.Channel.Booking(id_penerbangan, penumpangs, user_id);
        }
        
        public System.Threading.Tasks.Task<int> BookingAsync(int id_penerbangan, Travelancar.ItikAirService.penumpang[] penumpangs, int user_id) {
            return base.Channel.BookingAsync(id_penerbangan, penumpangs, user_id);
        }
        
        public Travelancar.ItikAirService.tiket[] GetPemesanan(int user_id) {
            return base.Channel.GetPemesanan(user_id);
        }
        
        public System.Threading.Tasks.Task<Travelancar.ItikAirService.tiket[]> GetPemesananAsync(int user_id) {
            return base.Channel.GetPemesananAsync(user_id);
        }
    }
}
