using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Models.Interfaces
{
    using Employees;

    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        IOrganizationalUnit InUnit { get; set; }
        decimal SalaryFactor { get; }
        decimal TotalPaid { get; set; }
        decimal RecieveSalary(decimal percents, decimal ceoSalary);
    }
}
