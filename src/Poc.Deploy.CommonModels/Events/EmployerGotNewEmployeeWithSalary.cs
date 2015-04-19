namespace Poc.Deploy.CommonModels.Events
{
    using System;

    public class EmployerGotNewEmployeeWithSalary
    {
        public int EmployerId { get; set; }

        public int AdditionalSalaryRate { get; set; }
    }
}