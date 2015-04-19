namespace Poc.Deploy.WriteWinService
{
    using System.Data.Entity;
    using System.Linq;

    using Poc.Deploy.CommonModels.Queries;
    using Poc.Deploy.WriteWinService.DataAccess;

    public class QueryHandler
    {
        public GetAllEmployersDataQueryResponse Handle(GetAllEmployersDataQuery query)
        {
            using (var context = new EmploymentDataDbContext())
            {
                var employers = context.Employers.Include(e => e.Employees).ToList();

                var employersSummaryList = new GetAllEmployersDataQueryResponse();
                employersSummaryList.Data =
                    employers.Select(
                        e =>
                        new EmployerSummaryData()
                            {
                                EmployerId = e.Id,
                                EmployerName = e.Name,
                                TotalSalary = e.Employees.Sum(ee => ee.Salary)
                            }).ToList();

                return employersSummaryList;
            }
        }
    }
}