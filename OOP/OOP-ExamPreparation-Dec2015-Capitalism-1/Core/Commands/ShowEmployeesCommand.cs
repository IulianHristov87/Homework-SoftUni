using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Core.Commands
{
    using Interfaces;
    using Models.Employees;
    using Models.Interfaces;

    class ShowEmployeesCommand : CommandAbstract
    {
        private string companyName;
        private CEO ceo;
        private StringBuilder output;

        public ShowEmployeesCommand(
            string companyName,
            IDatabase db) : base(db)
        {
            this.companyName = companyName;
        }

        public override string Execute()
        {
            IOrganizationalUnit company = this.db.Companies.FirstOrDefault(c => c.Name == this.companyName);
            if (company == null)
            {
                throw new ArgumentException(
                    string.Format("Company {0} does not exist", this.companyName));
            }
            ceo = (CEO)company.Head;
            PrintHierarchy(company, 0);
            return "";
        }

        private void PrintHierarchy(IOrganizationalUnit unit, int depth)
        {
            Console.WriteLine("{0}({1})", new String(' ', depth * 4), unit.Name);
            foreach (IEmployee employee in unit.Employees)
            {
                Console.WriteLine("{0}{1} {2} ({3:f2})", new String(' ', depth * 4), employee.FirstName, employee.LastName, employee.TotalPaid);
            }
            foreach (IOrganizationalUnit subUnit in unit.SubUnits)
            {
                this.PrintHierarchy(subUnit, depth + 1);
            }
        }
    }
}
