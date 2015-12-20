namespace Capitalism.Models.Interfaces
{
    public interface IPaidPerson: IPerson
    {
        decimal Salary { get; set; }
    }
}
