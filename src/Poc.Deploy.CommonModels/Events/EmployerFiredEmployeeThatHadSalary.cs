namespace Poc.Deploy.CommonModels.Events
{
    using System.Runtime.Serialization;

    [DataContract]
    public class EmployerFiredEmployeeThatHadSalary
    {
        [DataMember]
        public int EmployerId { get; set; }

        [DataMember]
        public int SalaryReductionValue { get; set; }
    }
}