using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MGMMVCSP.EmpRepo
{
    public class EmpRepo
    {
        public int SaveEmployee(Models.Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_addemp", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Eno", employee.Eno);
            sqlCommand.Parameters.AddWithValue("@Ename", employee.Ename);
            sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);

            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;

        }

        public int DeleteEmployee(Models.Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_deleteemp", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Eno", employee.Eno);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;

        }

        public int UpdateEmployee(Models.Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_updateemp", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Eno", employee.Eno);
            sqlCommand.Parameters.AddWithValue("@Ename", employee.Ename);
            sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;

        }

        public List<Models.Employee> GetEmployee(Models.Employee employee)
        {
            List<Models.Employee> empList = new List<Models.Employee>();
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_getemployee", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Models.Employee emp = new Models.Employee();
                    emp.Eno = Convert.ToInt32(sqlDataReader["Eno"]);
                    emp.Ename = sqlDataReader["Ename"].ToString();
                    emp.Salary = Convert.ToDouble(sqlDataReader["Salary"]);
                    empList.Add(emp);
                }
            }


            sqlConnection.Close();
            return empList;

        }

        public Models.Employee SearchEmp(Models.Employee emp)
        {
            Models.Employee employee = new Models.Employee();
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_getemp", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Eno", emp.Eno);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {

                    employee.Eno = Convert.ToInt32(sqlDataReader["Eno"]);
                    employee.Ename = sqlDataReader["Ename"].ToString();
                    employee.Salary = Convert.ToDouble(sqlDataReader["Salary"]);

                }
            }
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return employee;
        }
    }
}