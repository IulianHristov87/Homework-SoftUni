using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Models.Employees
{
    using Interfaces;

    public class Employee : IEmployee
    {
        public Employee(
            string firstName, 
            string lastName, 
            IOrganizationalUnit inUnit,
            decimal salaryFactor)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.InUnit = inUnit;
            this.SalaryFactor = salaryFactor;
        }

        public string FirstName { get; protected set; }

        public string LastName { get; protected set; }

        public IOrganizationalUnit InUnit { get; set; }

        public decimal SalaryFactor { get; protected set; }

        public decimal TotalPaid { get; set; }

        public virtual decimal RecieveSalary(decimal percents, decimal ceoSalary)
        {
            decimal toPay = ceoSalary * percents;
            toPay = toPay + toPay*this.SalaryFactor;
            this.TotalPaid += toPay;

            return toPay;
        }
    }
}
