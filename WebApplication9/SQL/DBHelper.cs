using System.Data.SqlClient;
using WebApplication9.Models;

namespace WebApplication9.SQL
{
    public class DBHelper
    {
        private readonly SqlConnection connection;
        public DBHelper()
        {
            var connectionString = "Server=localhost;Database=Employee;Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            
            var command = new SqlCommand("GetAllEmployees", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            var employees = new List<Employee>();
            Employee employee;
            while (reader.Read())
            {
                employee = new Employee();
                employee.FirstName = reader["FName"].ToString();
                employee.LastName = reader["LName"].ToString();
                employee.Age = int.Parse(reader["Age"].ToString()); 
                employees.Add(employee);
            }
            return employees;
        }


    }
}
