using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace MGMSPCRUD.EmpRepo
{
    public class Employee
    {
        SqlConnection con;
        public Employee()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());

        }

        public int SaveEmployee(Models.Employee objemp)
        {
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_saveemp", con);
            //mention that we are working with stodred procudure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //pass the parameters
            cmd.Parameters.AddWithValue("@eno", objemp.Eno);
            cmd.Parameters.AddWithValue("@ename", objemp.Ename);
            cmd.Parameters.AddWithValue("@salary", objemp.Salary);
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;

        }

        public int DeleteEmployee(Models.Employee objemp)
        {
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_deleteemp", con);
            //mention that we are working with stodred procudure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //pass the parameters
            cmd.Parameters.AddWithValue("@eno", objemp.Eno);
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;

        }
        public int UpdateEmployee(Models.Employee objemp)
        {
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_updateemp", con);
            //mention that we are working with stodred procudure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //pass the parameters
            cmd.Parameters.AddWithValue("@eno", objemp.Eno);
            cmd.Parameters.AddWithValue("@ename", objemp.Ename);
            cmd.Parameters.AddWithValue("@salary", objemp.Salary);
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;

        }

        public List<Models.Employee> GetEmployees()
        {
            List<Models.Employee> emps = new List<Models.Employee>();
            con.Open();

            SqlCommand cmd = new SqlCommand("proc_getemp", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Models.Employee emp = new Models.Employee();
                    emp.Eno = Convert.ToInt32(reader[0]);
                    emp.Ename = reader[1].ToString();
                    emp.Salary = Convert.ToDouble(reader[2]);
                    emps.Add(emp);

                }
            }
            con.Close();
            return emps;
        }

        public Models.Employee SearchEmployee(int id )
        {
            Models.Employee emp = new Models.Employee();
            //open the connection
            con.Open();
            //pass the procedure
            SqlCommand cmd = new SqlCommand("proc_searchemp", con);
            //mention that we are working with stodred procudure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //pass the parameters
            cmd.Parameters.AddWithValue("@eno", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                if (dataReader.Read())
                {

                    emp.Eno = Convert.ToInt32(dataReader[0]);
                    emp.Ename = dataReader[1].ToString();
                    emp.Salary = Convert.ToDouble(dataReader[2]);
                }
            }
            con.Close();
            return emp;

        }
    }
}