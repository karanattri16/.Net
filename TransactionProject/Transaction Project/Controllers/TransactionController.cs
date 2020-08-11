using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transaction_Project;
using Data_Layer_Transaction;

namespace Transaction_Project.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IRepository _repo;
        public TransactionController(IRepository repo)
        {
            _repo = repo;
        }
        

        public ActionResult Transaction()
        {
            return View("~/Views/Transaction.cshtml");
        }
       
        public void AddTransaction()
        {
           Transaction_Model model = new Transaction_Model()
            {
                Date = DateTime.Today.Date,
                Description = "Done on",
                Debit = 2000,
                Credit = 10000,
                Amount = 200
            };
            int output = _repo.Add_Transaction(model);
            
        }
    }
}