using PuyuhAir;
using PuyuhAirDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuyuhAirLogic
{
    public class PALogic
    {
        PuyuhAirDAO productDAO = new PuyuhAirDAO();

        public PuyuhAirBDO GetProduct(int id)
        {
            return productDAO.GetProduct(id);
        }
    }
    
}
