using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeDemo.EmpRepo
{
    public class EmpRepo
    {
        public int SaveEmployee(Models.Employee emp)
        {
            int result = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee (Eno, Ename, Salary) VALUES (@Eno, @Ename, @Salary)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@Eno", emp.Eno);
                    cmd.Parameters.AddWithValue("@Ename", emp.Ename);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);

                    con.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }


        public int DeleteEmployee(int id)
        {
            int result = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM employee WHERE Eno = @Eno";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Eno", id);

                    con.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }



        public Models.Employee SearchEmployee(Models.Employee employee)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from employee where eno = employee.Eno", con);
            SqlDataReader cm  = cmd.ExecuteReader();
            if (cm.HasRows)
            {
                while (cm.Read())
                {
                    employee.Ename = cm["Ename"].ToString();
                    employee.Salary = Convert.ToDouble(cm["Salary"]);
                }
            }
            con.Close();
            return employee;



        }
        public List<Models.Employee> GetEmployees()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            List<Models.Employee> empList = new List<Models.Employee>();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from employee", con);
            SqlDataReader cm = cmd.ExecuteReader();
            if(cm.HasRows)
                {
                
                while (cm.Read())
                {
                    Models.Employee emp = new Models.Employee();
                    emp.Eno = Convert.ToInt32(cm["Eno"]);
                    emp.Ename = cm["Ename"].ToString();
                    emp.Salary = Convert.ToDouble(cm["Salary"]);
                    empList.Add(emp);
                }
              
            }
            con.Close();
            return empList;

        }

    }
}