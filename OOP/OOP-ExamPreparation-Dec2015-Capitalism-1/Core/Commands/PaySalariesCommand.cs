using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Core.Commands
{
    using System.IO.Pipes;
    using Interfaces;
    using Models.Employees;
    using Models.Interfaces;

    class PaySalariesCommand : CommandAbstract
    {
        private string companyName;
        private CEO ceo;
        private StringBuilder output;

        public PaySalariesCommand(
            string companyName,
            IDatabase db) : base(db)
        {
            this.companyName = companyName;
            this.output = new StringBuilder();
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
            this.Pay(company, 0, 0);
            return this.output.ToString();
        }

        private decimal Pay(
            IOrganizationalUnit unit, 
            decimal paid, 
            int depth)
        {

            foreach (var dep in unit.SubUnits)
            {
                paid += this.Pay(dep, 0, depth + 1);
            }

            foreach (var emp in unit.Employees)
            {
                decimal percents = (15 - depth) * 0.01m;
                paid += emp.RecieveSalary(percents, this.ceo.Salary);
            }

            this.output.Insert(0,
                    string.Format("{0}{1} ({2:f2})\n",
                        new String(' ', depth * 4),
                        unit.Name,
                        paid
                        )
                    );

            return paid;
        }
    }
}
