using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism.Interfaces
{
    using Models.Interfaces;

    public interface IDatabase
    {
        IEnumerable<IOrganizationalUnit> Companies { get; }
        void AddCompany(IOrganizationalUnit company);
    }
}
