using Capitalism.Interfaces;
using Capitalism.Models;
using Capitalism.Models.Interfaces;
using System.Collections.Generic;

namespace Capitalism.Execution
{
    public class CapitalismDatabase : IDatabase
    {
        public CapitalismDatabase()
        {
            this.Companies = new List<Company>();
            this.TotalSalaries = new Dictionary<IPaidPerson, decimal>();
        }

        public ICollection<Company> Companies { get; private set; }

        public IDictionary<IPaidPerson, decimal> TotalSalaries { get; private set; }
    }
}
