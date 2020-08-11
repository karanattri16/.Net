using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data_Layer_Transaction;

namespace Transaction_Project
{
    public class Repository_Logic : IRepository
    {
        private readonly IDb_Layer _db_Layer;

        public Repository_Logic(IDb_Layer db_Layer)
        {
            _db_Layer = db_Layer;
        }
        
        public DB_Model Mapping(Transaction_Model model)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Transaction_Model, DB_Model>());
            //var mapper = config.CreateMapper();
            //var dbModel = mapper.Map<Transaction_Model, DB_Model>(model);

            var dbModel = Mapper.Map<Transaction_Model,DB_Model>(model);
            return dbModel;
        }

        public int Add_Transaction(Transaction_Model model)
        {
            var dbModel = Mapping(model);
            return _db_Layer.AddTransaction(dbModel);
        }

        //public List<Transaction_Model> Show_All_Transaction()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
