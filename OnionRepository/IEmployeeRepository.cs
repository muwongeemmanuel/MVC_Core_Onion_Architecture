using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnionDomain;

namespace OnionRepository
{
    public interface IEmployeeRepository
    {
        Task<bool> Add(Employee employee);
        Task<bool> Update(Employee employee);
        Task<bool> Delete(long employeeId);
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(long employeeId);
    }
}
