namespace Poc.Deploy.FrontEndApp.DataAccess
{
    using System.Linq;

    using Poc.Deploy.FrontEndApp.DataReadServices;

    public class EmployersRepository : IEmployersRepository
    {
        public EmployerSummaryData GetEmployerSummary(int employerId)
        {
            using (var queryServiceClient = new EmploymentQueryHandleServiceClient())
            {
                var allEmployers = queryServiceClient.Handle(new GetAllEmployersDataQuery());
                return allEmployers.Data.First(e => e.EmployerId == employerId);
            }
        }
    }
}