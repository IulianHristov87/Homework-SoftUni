using Capitalism.Interfaces;
using Capitalism.UserInterface;

namespace Capitalism.Execution
{
    public class CapitalismEngine : IEngine
    {
        private IUserInterface userInterface;
        private ICommandExecutor commandExecutor;

        public CapitalismEngine()
        {
            this.userInterface = new ConsoleUserInterface();
            this.commandExecutor = new CapitalismCommandExecutor();
        }

        public void Run()
        {
            while (true)
            {
                string commandLine = this.userInterface.ReadLine();
                if (commandLine == "end")
                {
                    break;
                }

                var command = new Command(commandLine);
                string commandResult = this.commandExecutor.ExecuteCommand(command);
                if (commandResult != null)
                {
                    this.userInterface.WriteLine(commandResult);
                }
            }
        }
    }
}