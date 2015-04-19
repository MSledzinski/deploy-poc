namespace Poc.Deploy.WriteWinService
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using Poc.Deploy.CommonModels.Queries;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class EmploymentQueryHandleService : IEmploymentQueryHandleService
    {
        public GetAllEmployersDataQueryResponse Handle(GetAllEmployersDataQuery query)
        {
            return (new QueryHandler()).Handle(query);
        }
    }
}