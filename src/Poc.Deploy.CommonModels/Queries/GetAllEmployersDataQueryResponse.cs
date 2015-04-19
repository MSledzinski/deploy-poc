namespace Poc.Deploy.CommonModels.Queries
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetAllEmployersDataQueryResponse
    {
        [DataMember]
        public IEnumerable<EmployerSummaryData> Data { get; set; }
    }
}