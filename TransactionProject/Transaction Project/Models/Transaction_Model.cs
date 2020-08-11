using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transaction_Project
{
    public class Transaction_Model
    {
        public DateTime Date { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public string  Description { get; set; }
        public float Amount { get; set; }
    }
}