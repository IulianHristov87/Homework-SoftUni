namespace Capitalism.Models
{
    public class ChiefTelephoneOfficer : Employee
    {
        private const double ChiefTelephoneOfficerSalaryFactor = 0.98;

        public ChiefTelephoneOfficer(string firstName, string lastName, Department department)
               : base(firstName, lastName, department)
        {
        }

        public ChiefTelephoneOfficer(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override double SalaryFactor
        {
            get
            {
                return ChiefTelephoneOfficerSalaryFactor;
            }
        }
    }
}
