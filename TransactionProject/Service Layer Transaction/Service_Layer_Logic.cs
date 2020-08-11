using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer_Transaction;
namespace Service_Layer_Transaction
{
    public class Service_Layer_Logic : IService_Layer
    {
        IDb_Layer _layer;
        public Service_Layer_Logic(IDb_Layer layer)
        {
            _layer = layer;
        }
        public int Add_Transaction(Service_Model model)
        {
            return 0;
        }

        public List<Service_Model> Show_All_Transaction()
        {
            throw new NotImplementedException();
        }
    }
}
