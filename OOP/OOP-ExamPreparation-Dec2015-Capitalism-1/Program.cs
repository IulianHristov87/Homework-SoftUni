using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationCapitalism
{
    using Core;
    using Core.Commands;
    using Core.Engines;
    using Interfaces;
    using Models.OrganizationalUnits;

    class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new Database();
            IEngine engine = new ConsoleCapitalismEngine(db);
            engine.Run();
        }

    }
}
