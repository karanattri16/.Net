using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer_Transaction
{
   public interface IService_Layer
    {
        int Add_Transaction(Service_Model model);
        List<Service_Model> Show_All_Transaction();
        
    }
}
