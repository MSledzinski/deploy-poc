namespace Poc.Deploy.WriteWinService
{
    using System.ServiceModel;

    using Poc.Deploy.CommonModels.Queries;

    [ServiceContract]
    public interface IEmploymentQueryHandleService
    {
        [OperationContract]
        GetAllEmployersDataQueryResponse Handle(GetAllEmployersDataQuery query);
    }
}