using Capitalism.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Capitalism.Models
{
    public class Company : ICompanyStructure
    {
        private string name;
        private CEO ceo;

        public Company(string name, CEO ceo)
        {
            this.Name = name;
            this.CEO = ceo;
            this.Employees = new List<IEmployee>();
            this.Departments = new List<Department>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "The name cannot be empty.");
                }

                this.name = value;
            }
        }

        public CEO CEO
        {
            get
            {
                return this.ceo;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("CEO", "A company must have a CEO.");
                }

                this.ceo = value;
            }
        }

        public ICollection<Department> Departments { get; set; }

        public ICollection<IEmployee> Employees { get; set; }
    }
}
