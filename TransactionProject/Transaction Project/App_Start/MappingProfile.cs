using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using AutoMapper;
using Data_Layer_Transaction;
using Transaction_Project;

namespace Transaction_Project.App_Start.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Transaction_Model,DB_Model>();
            CreateMap<DB_Model, Transaction_Model>().ReverseMap();
        }
    }
}
        