using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                String ConncetionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> Employees = new List<Employee>();
                using (SqlConnection Connection = new SqlConnection(ConncetionString))
                {
                    SqlCommand command = new SqlCommand("GetAllEmployees", Connection);
                    command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        Employee employee = new Employee();
                        employee.EID = Convert.ToInt32(rd["EID"]);
                        employee.EmployeeName = rd["Name"].ToString();
                        employee.Gender = rd["Gender"].ToString();
                        employee.City = rd["City"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(rd["DateOfBirth"]);
                        Employees.Add(employee);
                    }
                }
                return Employees;
            }
        }
    }
}
