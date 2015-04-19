namespace Poc.Deploy.WriteWinService
{
    using System.ServiceModel;

    using Poc.Deploy.CommonModels.Commands;

    [ServiceContract]
    public interface IEmploymentCommandsHandleService
    {
        [OperationContract]
        void Handle(HireEmployeeByEmployerCommand command);
    }
}
