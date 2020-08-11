using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Transaction
{
   public interface IDb_Layer
    {
        int AddTransaction(DB_Model model);
        List<DB_Model> ShowAllTransaction();
    }
}
