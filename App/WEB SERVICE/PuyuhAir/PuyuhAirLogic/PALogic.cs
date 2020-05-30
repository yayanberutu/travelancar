using PuyuhAir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuyuhAirLogic
{
    public class PALogic
    {
        PuyuhAirBDO productBDO = new PuyuhAirBDO();
        public PuyuhAirBDO GetProduct(int id)
        {
            return productBDO.GetProduct(id);
        }
    }
    
}
