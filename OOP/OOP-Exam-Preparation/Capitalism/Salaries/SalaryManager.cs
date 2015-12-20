using Capitalism.Interfaces;
using Capitalism.Models;
using Capitalism.Models.Interfaces;
using System;
using System.Linq;

namespace Capitalism.Salaries
{
    public class SalaryManager
    {
        public decimal GetSalary(IEmployee employee, Company company)
        {
            return (decimal)employee.SalaryFactor * GetSalaryPercentage(employee, company) * company.CEO.Salary;
        }

        private decimal GetSalaryPercentage(IEmployee employee, Company company)
        {
            decimal salaryPercentage = 0.15m;
            if (employee.Department == null)
            {
                return salaryPercentage;
            }

            salaryPercentage = GetSalaryPercentage(employee.Department.Manager, company) - 0.01m;
            return salaryPercentage;
        }
    }
}
