namespace Capitalism.Models
{
    public class CleaningLady : Employee
    {
        private const double CleaningLadySalaryFactor = 0.98;

        public CleaningLady(string firstName, string lastName, Department department)
               : base(firstName, lastName, department)
        {
        }

        public CleaningLady(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override double SalaryFactor
        {
            get
            {
                return CleaningLadySalaryFactor;
            }
        }
    }
}
