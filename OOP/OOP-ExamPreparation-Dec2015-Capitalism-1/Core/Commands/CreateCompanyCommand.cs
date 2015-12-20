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


    public class CreateCompanyCommand : CommandAbstract
    {
        private string companyName;
        private string ceoFirstName;
        private string ceoLastName;
        private decimal ceoSalary;

        public CreateCompanyCommand(
            IDatabase db,
            string companyName,
            string ceoFirstName,
            string ceoLastName,
            decimal ceoSalary
            ) 
            : base(db)
        {
            this.companyName = companyName;
            this.ceoFirstName = ceoFirstName;
            this.ceoLastName = ceoLastName;
            this.ceoSalary = ceoSalary;
        }

        public override string Execute()
        {
            foreach (IOrganizationalUnit c 
                in this.db.Companies)
            {
                if (c.Name == this.companyName)
                {
                    throw new Exception(string.Format("Company {0} already exists", this.companyName));
                }
            }
        
            IOrganizationalUnit company = new Company(this.companyName);
            IEmployee ceo = EmployeeFactory.Create(this.ceoFirstName, this.ceoLastName, "CEO", company, this.ceoSalary);
            this.db.AddCompany(company);
            company.AddEmployee(ceo);
            company.Head = ceo;
            return "";
        }
    }
}
