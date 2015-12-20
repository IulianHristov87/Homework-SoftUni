using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
