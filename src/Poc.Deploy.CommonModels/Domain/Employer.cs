namespace Poc.Deploy.CommonModels.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class Employer
    {
        // for EF's sake
        private Employer()
        {
            
        }

        public Employer(int id, string name, ICollection<Employee> subItems = null)
        {
            this.Id = id;
            this.Name = name;
            this.Employees = subItems ?? new Collection<Employee>();
        }

        public int Id { get; private set; }

        public string Name { get; private set; } 
    
        public virtual ICollection<Employee> Employees { get; private set; }

        public int CalculateTotalSalaryAmount()
        {
            // 55 is a bonus for employer :)
            return this.Employees.Sum(i => i.Salary) + 55;
        }

        public void FireAnEmployee(int employeeId)
        {
            var employee = this.Employees.Single(e => e.Id == employeeId);
            this.Employees.Remove(employee);
        }
    }
}