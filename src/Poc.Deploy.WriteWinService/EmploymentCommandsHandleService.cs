namespace Poc.Deploy.WriteWinService
{
    using System.ServiceModel;

    using Poc.Deploy.CommonModels.Commands;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class EmploymentCommandsHandleService : IEmploymentCommandsHandleService
    {
        public void Handle(HireEmployeeByEmployerCommand command)
        {
            (new CommandHandler()).Handle(command);
        }
    }
}
