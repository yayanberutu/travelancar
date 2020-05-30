using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PinguinAir;

namespace PinguinAirLogic
{
    public class PGNlogic
    {
        PinguinAirBDO productBDO = new PinguinAirBDO();
        public PinguinAirBDO GetProduct(int id)
        {
            return productBDO.GetProduct(id);
        }
    }
}
