using MvcApplication23.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication23.ModelClass
{
    public class studentviewmodel
    {

        string cs = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
        public string insert_loginmethod(students stu)
        {
            string s = "";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_employees", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_name", SqlDbType.NVarChar, 50).Value = stu.stu_name;
                cmd.Parameters.Add("@emp_email", SqlDbType.NVarChar, 50).Value = emp.emp_email;
                conn.Open();
                cmd.ExecuteNonQuery();


                s = "DATA record has been inserted successfully.....";

            }
            catch (Exception)
            {
                s = "data is not inserted !!!";

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........


    }
}