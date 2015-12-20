namespace Capitalism.Interfaces
{
    public interface ICommandExecutor
    {
        string ExecuteCommand(ICommand command);
    }
}
