using Poc.Deploy.FrontEndApp.DataReadServices;

namespace Poc.Deploy.FrontEndApp.DataAccess
{
    public interface IEmployersRepository
    {
        EmployerSummaryData GetEmployerSummary(int employerId);
    }
}