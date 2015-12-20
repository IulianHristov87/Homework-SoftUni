namespace Capitalism.Models
{
    public class Salesman : Employee
    {
        private const double SalesmanSalaryFactor = 1.015;

        public Salesman(string firstName, string lastName, Department department)
               : base(firstName, lastName, department)
        {
        }

        public Salesman(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override double SalaryFactor
        {
            get
            {
                return SalesmanSalaryFactor;
            }
        }
    }
}
