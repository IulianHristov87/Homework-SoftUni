using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Models.OrganizationalUnits
{
    using Interfaces;

    public class Company : IOrganizationalUnit
    {
        private readonly IList<IOrganizationalUnit> subUnits;
        private readonly IList<IOrganizationalUnit> allDepartments; 
        private readonly IList<IEmployee> employees;
        private readonly IList<IEmployee> allEmployees; 
        public string Name { get; private set; }

        public Company(string name)
        {
            this.subUnits = new List<IOrganizationalUnit>();
            this.employees = new List<IEmployee>();
            this.allEmployees = new List<IEmployee>();
            this.allDepartments = new List<IOrganizationalUnit>();
            this.Name = name;
        }

        public IEnumerable<IOrganizationalUnit> SubUnits
        {
            get { return this.subUnits; }
        }

        public IList<IOrganizationalUnit> AllDepartments
        {
            get { return this.allDepartments; }
        } 
       

        public IEnumerable<IEmployee> Employees
        {
            get { return this.employees; }
        }

        public IList<IEmployee> AllEmployees
        {
            get { return this.allEmployees; }
        }

        public IEmployee Head { get; set; }

        public void AddSubUnit(IOrganizationalUnit unit)
        {
            this.subUnits.Add(unit);
        }

        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            this.employees.Remove(employee);
        }
    }
}
