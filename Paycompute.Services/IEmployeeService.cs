using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        IEnumerable<Employee> GetAll();
        Employee GetById(int employeeId);
        Task Delete(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Decimal UnionFees(int id);
        Decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);

    }
}
