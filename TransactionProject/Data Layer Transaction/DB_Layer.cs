using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Data_Layer_Transaction
{
    public class DB_Layer : IDb_Layer
    {
        string DBCS = ConfigurationManager.ConnectionStrings["MyDBCS"].ConnectionString;

        public int AddTransaction(DB_Model model)
        {
            SqlConnection conn = new SqlConnection(DBCS);
            SqlCommand cmd = new SqlCommand("Add_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", model.Date);
            cmd.Parameters.AddWithValue("@Desc", model.Description);
            cmd.Parameters.AddWithValue("@Amount", model.Amount);
            cmd.Parameters.AddWithValue("@Credit", model.Credit);
            cmd.Parameters.AddWithValue("@Debit", model.Debit);
            int output;
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            if(rowAffected>0)
            {
                output = 1;
            }
            else
            {
                output = 0;
            }
            conn.Close();

            return output;

        }

        public List<DB_Model> ShowAllTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
