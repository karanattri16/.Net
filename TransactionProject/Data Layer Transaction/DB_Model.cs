﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer_Transaction
{
    public class DB_Model
    {
        public DateTime Date { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
    }
    
}
