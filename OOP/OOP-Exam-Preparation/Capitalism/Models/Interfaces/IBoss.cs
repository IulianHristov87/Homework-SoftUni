using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    public interface IBoss
    {
        ICollection<IEmployee> SubordinateEmployees { get; }
    }
}
