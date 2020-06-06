using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnionDomain;

namespace OnionService
{
    public interface IEmployeeService
    {
        Task<bool> AddAsync(Employee employee);
        Task<bool> UpdateAsync(Employee employee);
        IEnumerable<Employee> GetEmployeesAsync();
        Employee GetEmployeeByIdAsync(long employeeId);
        Task<bool> DeleteAsync(long employeeId);
    }
}
