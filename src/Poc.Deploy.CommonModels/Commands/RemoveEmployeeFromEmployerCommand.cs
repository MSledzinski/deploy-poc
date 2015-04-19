namespace Poc.Deploy.CommonModels.Commands
{
    using System.Runtime.Serialization;

    [DataContract]
    public class RemoveEmployeeFromEmployerCommand
    {
        [DataMember]
        public int EmployerId { get; set; }

        [DataMember]
        public int EmployeeId { get; set; }
    }
}