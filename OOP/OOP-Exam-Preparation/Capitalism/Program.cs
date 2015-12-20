using System.Globalization;
using System.Threading;
using Capitalism.Execution;
using Capitalism.Interfaces;

namespace Capitalism
{
    public class Program
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            IEngine engine = new CapitalismEngine();
            engine.Run();
        }
    }
}
