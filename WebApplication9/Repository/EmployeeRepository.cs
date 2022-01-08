using WebApplication9.Models;

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
            var employees = new List<Employee>()
           {
               new Employee{FirstName="Chandra", Age=40, LastName="Dha",Phone="989898989"},
                new Employee{FirstName="Ravi", Age=30, LastName="TT",Phone="900000000000"},
                 new Employee{FirstName="Sathya", Age=25, LastName="Ravi",Phone="91111111111"}
           };
            return employees;
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
