using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Core
{
    using Interfaces;
    using Models.Interfaces;

    public class Database : IDatabase
    {
        private readonly IList<IOrganizationalUnit> companies; 
        
        public Database()
        {
            this.companies = new List<IOrganizationalUnit>();
        }

        public IEnumerable<IOrganizationalUnit> Companies
        {
            get { return this.companies; }
        }

        public void AddCompany(IOrganizationalUnit company)
        {
            this.companies.Add(company);
        }
    }
}
