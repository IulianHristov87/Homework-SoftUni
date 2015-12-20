using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    public interface ICompanyStructure
    {
        string Name { get; }

        ICollection<IEmployee> Employees { get; }
    }
}
