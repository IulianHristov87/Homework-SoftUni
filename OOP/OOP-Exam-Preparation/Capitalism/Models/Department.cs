namespace Capitalism.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class Department : ICompanyStructure
    {
        private string name;
        private Manager manager;

        public Department(string name, Manager manager)
        {
            this.Name = name;
            this.Manager = manager;
            this.Employees = new List<IEmployee>();
            this.SubDepartments = new List<Department>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentNullException("Name", "The name cannot be empty.");
                }

                this.name = value;
            }
        }

        public Manager Manager
        {
            get
            {
                return this.manager;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("manager", "A department must have a manager.");
                }

                this.manager = value;
            }
        }

        public ICollection<IEmployee> Employees { get; set; }

        public ICollection<Department> SubDepartments { get; set; }
    }
}