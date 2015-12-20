using Capitalism.Models;
using Capitalism.Models.Interfaces;
using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    public interface IDatabase
    {
        ICollection<Company> Companies { get; }

        IDictionary<IPaidPerson, decimal> TotalSalaries { get; }
    }
}
