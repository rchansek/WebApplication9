using WebApplication9.Models;
using WebApplication9.SQL;

namespace WebApplication9.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee Create(Employee employee)
        {
            //SQL call for Insert Into 
            throw new NotImplementedException();
        }

        public bool Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            //SQL 
            var dbHelper = new DBHelper();
            return dbHelper.GetEmployeeList();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdatebyId(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
