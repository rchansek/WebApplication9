using WebApplication9.Models;

namespace WebApplication9.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee UpdatebyId(Employee employee);
        bool Delete(Employee employee);
        Employee Create(Employee employee);
    }
}
