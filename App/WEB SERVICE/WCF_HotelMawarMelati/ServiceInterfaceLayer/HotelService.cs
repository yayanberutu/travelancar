using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessDomainObject;
using BusinessLogic;

namespace ServiceInterfaceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HotelService : IHotelService
    {
        KamarBL kamarLogic = new KamarBL();
        BookingBL bookingLogic = new BookingBL();
        public IEnumerable<Kamar> getAllKamar()
        {
            IEnumerable<KamarBDO> listkamarBDO = null;
            try
            {
                listkamarBDO = kamarLogic.getAllKamar();
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string reason = "GetAllKamarException";
                throw new FaultException<HotelMawarMelatiFault>(new HotelMawarMelatiFault(msg), reason);
            }
            if (listkamarBDO == null)
            {
                string msg = string.Format("Kamar Not Found");
                string reason = "GetAllKamarException";
                throw new FaultException<HotelMawarMelatiFault>(new HotelMawarMelatiFault(msg), reason);
            }
            List<Kamar> kamars = new List<Kamar>();
            foreach (var k in listkamarBDO)
            {
                Kamar kamar = new Kamar();
                TranslateKamarBDOToKamarDTO(k, kamar);
                kamars.Add(kamar);
            }
            return kamars;
        }

        public void InsertBooking(Booking booking, Kamar kmr)
        {
            try
            {
                BookingBDO bookBDO = new BookingBDO();
                KamarBDO kmrBDO = new KamarBDO();
                TranslateBookingDTOToBookingBDO(booking, bookBDO);
                TranslateKamarDTOToKamarBDO(kmr, kmrBDO);
                bookingLogic.InsertBooking(bookBDO, kmrBDO);
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string reason = "InsertBooking Exception";
                throw new FaultException<HotelMawarMelatiFault>(new HotelMawarMelatiFault(msg), reason);
            }
        }

        public void TranslateKamarBDOToKamarDTO(KamarBDO kmrBDO, Kamar kmr)
        {
            kmr.id = kmrBDO.id;
            kmr.no_kamar = kmrBDO.no_kamar;
            kmr.harga_akhir_pekan = kmrBDO.harga_akhir_pekan;
            kmr.harga_biasa = kmrBDO.harga_biasa;   
            kmr.fasilitas = kmrBDO.fasilitas;
            kmr.kapasitas = kmrBDO.kapasitas;
            kmr.status = kmrBDO.status;
        }

        public void TranslateKamarDTOToKamarBDO(Kamar kmr, KamarBDO kmrBDO)
        {
            kmrBDO.id = kmr.id;
            kmrBDO.no_kamar = kmr.no_kamar;
            kmrBDO.harga_akhir_pekan = kmr.harga_akhir_pekan;
            kmrBDO.harga_biasa = kmr.harga_biasa;
            kmrBDO.fasilitas = kmr.fasilitas;
            kmrBDO.kapasitas = kmr.kapasitas;
            kmrBDO.status = kmr.status;

        }

        public void TranslateBookingBDOToBookingDTO(BookingBDO bookBDO, Booking book)
        {
            book.id_user = bookBDO.id_user;
            book.kode_booking = bookBDO.kode_booking;
            book.tanggal_booking = bookBDO.tanggal_booking;
            book.tanggal_mulai = bookBDO.tanggal_mulai;
            book.tanggal_selesai = bookBDO.tanggal_selesai;
        }

        public void TranslateBookingDTOToBookingBDO(Booking book, BookingBDO bookBDO)
        {
            bookBDO.id_user = book.id_user;
            bookBDO.kode_booking = book.kode_booking;
            bookBDO.tanggal_booking = book.tanggal_booking;
            bookBDO.tanggal_mulai = book.tanggal_mulai;
            bookBDO.tanggal_selesai = book.tanggal_selesai;
        }
    }
}
