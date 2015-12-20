namespace Capitalism.Interfaces
{
    public interface IUserInterface : IReader, IWriter
    {
        // This interface is empty because it only combines
        // IReader and IWriter and does not include
        // any new members
    }
}