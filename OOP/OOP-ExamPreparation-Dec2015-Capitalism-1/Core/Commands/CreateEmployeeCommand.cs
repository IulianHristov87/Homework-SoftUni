using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Core.Commands
{
    using Factories;
    using Interfaces;
    using Models.Interfaces;
    using Models.OrganizationalUnits;

    public class CreateEmployeeCommand : CommandAbstract
    {
        private string companyName;
        private string departmentName;
        private string firstName;
        private string lastName;
        private string position;

        public CreateEmployeeCommand(
            IDatabase db,
            string firstName,
            string lastName,
            string position,
            string companyName,
            string departmentName = null
            ) 
            : base(db)
        {
            this.companyName = companyName;
            this.departmentName = departmentName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        public override string Execute()
        {
            Company company = this.db.Companies.Cast<Company>().FirstOrDefault(c => c.Name == this.companyName);

            if (company == null)
            {
                throw new ArgumentException(
                    string.Format("Company {0} does not exist", this.companyName));
            }

            foreach (IEmployee e in company.AllEmployees)
            {
                if (e.FirstName == this.firstName && e.LastName == this.lastName)
                {
                    if (e.InUnit is Company)
                    {
                        throw new ArgumentException(
                            string.Format(
                                "Employee {0} {1} already exists in {2} (no department)",
                                this.firstName,
                                this.lastName,
                                this.companyName
                                ));
                    }
                    else
                    {
                        throw new ArgumentException(
                           string.Format(
                               "Employee {0} {1} already exists in {2} (in department {3})",
                               this.firstName,
                               this.lastName,
                               this.companyName,
                               e.InUnit.Name
                               ));
                    }
                }
            }

            IOrganizationalUnit inUnit = company;
            if (this.departmentName != null)
            {
                foreach (IOrganizationalUnit d in company.AllDepartments)
                {
                    if (d.Name == this.departmentName)
                    {
                        inUnit = d;
                        break;
                    }
                }
            }

            IEmployee employee = EmployeeFactory.Create(
                this.firstName,
                this.lastName,
                this.position,
                inUnit
                );

            company.AllEmployees.Add(employee);
            inUnit.AddEmployee(employee);
            return "";
        }
    }
}
