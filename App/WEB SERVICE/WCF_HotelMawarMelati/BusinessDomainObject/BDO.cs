using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDomainObject
{
    public class KamarBDO
    {
        public string id { get; set; }
        public string no_kamar { get; set; }
        public double harga_akhir_pekan { get; set; }
        public double harga_biasa { get; set; }
        public int kapasitas { get; set; }
        public string fasilitas { get; set; }
        public int status { get; set; }

        public IEnumerable<KamarBDO> getAllKamar()
        {

            List<Kamar> listkamar = new List<Kamar>();
            List<KamarBDO> lkBDO = new List<KamarBDO>();
            using (var db = new HotelMawarMelatiEntities())
            {
                listkamar = (from p in db.Kamars where p.status == 1 select p).ToList();
            }
            foreach (var k in listkamar)
            {
                KamarBDO data = new KamarBDO()
                {
                    id = k.id,
                    no_kamar = k.no_kamar,
                    harga_akhir_pekan = k.harga_akhir_pekan,
                    harga_biasa = k.harga_biasa,
                    kapasitas = k.kapasitas,
                    fasilitas = k.fasilitas,
                    status = k.status
                };
                lkBDO.Add(data);
            }
            return lkBDO;
        }
    }

    public class BookingBDO
    {
        public string kode_booking { get; set; }
        public string id_user { get; set; }
        public DateTime tanggal_booking { get; set; }
        public DateTime tanggal_mulai { get; set; }
        public DateTime tanggal_selesai { get; set; }

        public void InsertBooking(BookingBDO booking, KamarBDO kmr)
        {
            Booking bo = new Booking()
            {
                kode_booking = booking.kode_booking,
                id_user = booking.id_user,
                tanggal_booking = booking.tanggal_booking,
                tanggal_mulai = booking.tanggal_mulai,
                tanggal_selesai = booking.tanggal_selesai
            };
            BookingHistory bh = new BookingHistory();
            bh.kode_booking = booking.id_user;
            bh.id_kamar = kmr.id;
            using (var db = new HotelMawarMelatiEntities())
            {
                db.Bookings.Add(bo);
                db.BookingHistories.Add(bh);
                db.SaveChanges();
            }
        }

    }

    public class BookingHistoryBDO
    {
        public string kode_booking;
        public string id_kamar;
    }
}
