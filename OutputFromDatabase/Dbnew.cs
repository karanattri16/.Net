using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OutputFromDatabase
{
    class Dbnew
    {
        private string Name { get; set; }
        private string Gender { get; set; }
        
        public int AddEmp(string name, string gender)
        {
            this.Name = name;
            this.Gender = Gender;
            SqlConnection conn = new SqlConnection("Server=admin;database=StoredProcedureMVC;integrated security= true");
            string proc = "spCustomerAdd";
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@Gender", gender));
            SqlParameter para1 =new SqlParameter("@Id", SqlDbType.Int);
            para1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para1);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return (int)para1.Value;
        }
    }
}
