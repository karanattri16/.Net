using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace OutputFromDatabase
{
    class Db
    {
        public static int CreateEmp(string name, string gender)
        {
            SqlConnection conn = new SqlConnection("server=admin; database=StoredProcedureMVC; integrated security=true");

            string procedure = "spCustomerAdd";
            SqlCommand cmd = new SqlCommand(procedure,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter para1 = new SqlParameter("@Id",SqlDbType.Int);
            para1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para1);
			cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@Gender", gender));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return (int)para1.Value;
            
        }
        
    }
}
