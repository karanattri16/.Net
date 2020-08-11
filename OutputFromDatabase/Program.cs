using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputFromDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Db.CreateEmp("shubham", "Male");
            Dbnew d = new Dbnew();
            int a = d.AddEmp("salman", "Male");
            Console.WriteLine(a);
        }
    }
}
