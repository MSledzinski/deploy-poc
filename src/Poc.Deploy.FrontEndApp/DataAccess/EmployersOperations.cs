namespace Poc.Deploy.FrontEndApp.DataAccess
{
    using Poc.Deploy.FrontEndApp.DataOperationServices;

    public class EmployersOperations : IEmployersOperations
    {
        public void HireEmployee(int employerId, string employeeName, int employeeSalary)
        {
            using (var commandsService = new EmploymentCommandsHandleServiceClient())
            {
                commandsService.Handle(
                    new HireEmployeeByEmployerCommand()
                        {
                            EmployerId = employerId,
                            EmployeeName = employeeName,
                            EmployeeSalary = employeeSalary
                        });


            }
        }
    }
}