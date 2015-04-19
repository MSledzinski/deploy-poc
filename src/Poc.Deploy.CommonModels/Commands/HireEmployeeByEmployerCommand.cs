namespace Poc.Deploy.CommonModels.Commands
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class HireEmployeeByEmployerCommand
    {
        [DataMember]
        public int EmployerId { get; set; }

        [DataMember]
        public string EmployeeName { get; set; }

        [DataMember]
        public int EmployeeSalary { get; set; }
    }
}