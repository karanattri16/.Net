using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Project
{
   public interface IRepository
    {
        int Add_Transaction(Transaction_Model model);
        //List<Service_Model> Show_All_Transaction();
        
    }
}
