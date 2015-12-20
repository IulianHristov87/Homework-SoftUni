using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Models.Employees
{
    using Interfaces;

    public class CEO : Employee
    {
        private const decimal SalaryFactorDefault = 0;

        public CEO(string firstName, string lastName, IOrganizationalUnit inUnit, decimal salary)
            : base(firstName, lastName, inUnit, SalaryFactorDefault)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override decimal RecieveSalary(decimal percents, decimal ceoSalary)
        {
            this.TotalPaid += this.Salary;

            return this.Salary;
        }
    }
}
