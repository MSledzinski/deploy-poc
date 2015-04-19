namespace Poc.Deploy.CommonModels.Queries
{
    using System.Runtime.Serialization;

    [DataContract]
    public class EmployerSummaryData
    {
        [DataMember]
        public int EmployerId { get; set; }

        [DataMember]
        public string EmployerName { get; set; }

        [DataMember]
        public int TotalSalary { get; set; }
    }
}