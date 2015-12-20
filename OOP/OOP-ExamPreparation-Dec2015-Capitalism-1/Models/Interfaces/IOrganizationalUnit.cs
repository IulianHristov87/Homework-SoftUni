using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Models.Interfaces
{
    public interface IOrganizationalUnit
    {
        string Name { get; }
        IEnumerable<IOrganizationalUnit> SubUnits { get; }
        IEnumerable<IEmployee> Employees { get; }
        IEmployee Head { get; set; }
        void AddSubUnit(IOrganizationalUnit unit);
        void AddEmployee(IEmployee employee);
        void RemoveEmployee(IEmployee employee);
    }
}
