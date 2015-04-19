namespace Poc.Deploy.CommonModels.Domain
{
    public class Employee
    {
        // for EF's sake
        private Employee()
        {
            
        }

        public Employee(int id, int salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }

        public int Id { get; private set; }

        // should be Monay - I know :)
        public int Salary { get; private set; }

        public string Name { get; private set; }
    }
}