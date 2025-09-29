using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    // Class to hold the result of database operations
    public class Result
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public DataTable Data { get; set; }
    }

    internal class DbHelper
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-MH8FO6G;Initial Catalog=Air.Ticket.Management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        // Method to get data from database
        public static Result GetQueryData(string query)
        {
            var result = new Result();

            try
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                con.Close();

                result.Data = dt;
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        // Method to execute non-query commands (INSERT, UPDATE, DELETE)
        public static Result ExecuteNonResultQuery(string query)
        {
            var result = new Result();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
            }
            finally
            {
                con.Close();
            }

            return result;
        }
    }
}
