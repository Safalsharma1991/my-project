using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace MVCCrud.EmpRepo
{
    public class Employee
    {
        public int SaveEmployee(Models.Employee emp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();

            string query = "INSERT INTO emp VALUES ('" + emp.Eno + "', '" + emp.Ename + "', '" + emp.Salary + "');";

            SqlCommand cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;

        }
        public int DeleteEmployee(Models.Employee emp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string query = "Delete from emp where eno = " + emp.Eno;
            SqlCommand cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;

        }

        public int UpdateEmployee(Models.Employee emp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();

            string query = "UPDATE emp SET ename = '" + emp.Ename + "', salary = '" + emp.Salary + "' WHERE eno = " + emp.Eno;
            SqlCommand cmd = new SqlCommand(query, con);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;
        }

        public List<Models.Employee> getEmps()
        {
            List<Models.Employee> emps = new List<Models.Employee>();
            SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings
                ["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Models.Employee emp = new Models.Employee();
                    emp.Eno = Convert.ToInt32(dr[0]);
                    emp.Ename = dr[1].ToString();
                    emp.Salary = double.Parse(dr[2].ToString());
                    emps.Add(emp);
                }
            }
            con.Close();
            return emps;
        }


    }
}