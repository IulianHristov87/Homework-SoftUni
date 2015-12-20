namespace Capitalism.Models.Interfaces
{
    public interface IEmployee : IPaidPerson
    {
        Department Department { get; set; }

        double SalaryFactor { get; }
    }
}