using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class KamarBL
    {
        BusinessDomainObject.KamarBDO kamarBDO = new BusinessDomainObject.KamarBDO();
        public IEnumerable<BusinessDomainObject.KamarBDO> getAllKamar()
        {
            return kamarBDO.getAllKamar();
        }
    }

    public class BookingBL
    {
        BusinessDomainObject.BookingBDO bookingBDO = new BusinessDomainObject.BookingBDO();
        public void InsertBooking(BusinessDomainObject.BookingBDO booking,  BusinessDomainObject.KamarBDO kmr)
        {
            bookingBDO.InsertBooking(booking, kmr);
        }

    }
}
