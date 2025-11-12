using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MGMMVCDemo.EmpRepo
{
    public class EmpRepo
    {
        public int SaveEmployee(Models.Employee employee)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string query = "insert into employee values ('" + employee.Eno + "','" + employee.Ename + "','" + employee.Salary + "')";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            int i = sqlCommand.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}