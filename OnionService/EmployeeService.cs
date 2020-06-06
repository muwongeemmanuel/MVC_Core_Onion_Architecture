using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnionDomain;
using OnionRepository;

namespace OnionService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<bool> AddAsync(Employee employee)
        {
            try
            {
                var obj = new Employee();
                obj.FirstName = employee.FirstName;
                obj.LastName = employee.LastName;
                obj.Position = employee.Position;
                obj.Department = employee.Department;
                obj.DOB = employee.DOB;
                obj.Salary = employee.Salary;
                var result = await _employeeRepository.Add(obj);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }



        }
        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                var result = await _employeeRepository.Delete(id);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public IEnumerable<Employee> GetEmployeesAsync()
        {
            var employeeList = new List<Employee>();
            var result = _employeeRepository.GetEmployees();
            foreach (var item in result)
            {
                employeeList.Add(new Employee
                {
                    EmployeeId = item.EmployeeId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Position = item.Position,
                    Department = item.Department,
                    DOB = item.DOB,
                    Salary = item.Salary
            });
            }
            return employeeList;
        }

        public Employee GetEmployeeByIdAsync(long id)
        {
            var result =_employeeRepository.GetEmployeeById(id);
            var employee = new Employee();
            employee.EmployeeId = result.EmployeeId;
            employee.FirstName = result.FirstName;
            employee.LastName = result.LastName;
            employee.Position = result.Position;
            employee.Department = result.Department;
            employee.DOB = result.DOB;
            employee.Salary = result.Salary;

            return employee;
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            try
            {
                var obj = new Employee();
                obj.EmployeeId = employee.EmployeeId;
                obj.FirstName = employee.FirstName;
                obj.LastName = employee.LastName;
                obj.Position = employee.Position;
                obj.Department = employee.Department;
                obj.DOB = employee.DOB;
                obj.Salary = employee.Salary;
                var result = await _employeeRepository.Update(obj);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
