using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EFDataAccessLibrary.Models
{
   public class WorkerDB
    {
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EFTestDB; Integrated Security = True");

        public string SaveRecord(Worker work)
        {
            try
            {
                SqlCommand com = new SqlCommand("Sp_Worker_Add", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", work.Name);
                com.Parameters.AddWithValue("@Surname", work.Surname);
                com.Parameters.AddWithValue("@Hobbies", work.Hobbies);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("ok");
            }
            catch (Exception ex) 
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString()); 

            }
        }
    }
}
