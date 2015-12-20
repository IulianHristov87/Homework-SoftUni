namespace Capitalism.Models
{
    public class Accountant : Employee
    {
        public Accountant(string firstName, string lastName, Department department)
               : base(firstName, lastName, department)
        {
        }


        public Accountant(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
