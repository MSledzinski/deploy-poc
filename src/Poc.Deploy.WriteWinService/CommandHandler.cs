namespace Poc.Deploy.WriteWinService
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Poc.Deploy.CommonModels.Commands;
    using Poc.Deploy.CommonModels.Domain;
    using Poc.Deploy.WriteWinService.DataAccess;

    public class CommandHandler
    {
        public void Handle(dynamic commnad)
        {
            this.HandleInternal(commnad);
        }

        private void HandleInternal(HireEmployeeByEmployerCommand command)
        {
            using (var context = new EmploymentDataDbContext())
            {
                var nextKey = context.Employees.Count() + 1; // :)

                var employee = new Employee(nextKey, command.EmployeeSalary, command.EmployeeName);

                var employer = FindWithId(context, command.EmployerId);

                context.Employees.Add(employee);
                employer.Employees.Add(employee);

                context.SaveChanges();
            }
        }

        private void HandleInternal(RemoveEmployeeFromEmployerCommand command)
        {
            using (var context = new EmploymentDataDbContext())
            {
                var employer = FindWithId(context, command.EmployerId);

                employer.FireAnEmployee(command.EmployeeId);

                context.SaveChanges();
            }
        }

        private Employer FindWithId(EmploymentDataDbContext context, int id)
        {
            return context.Employers.Where(e => e.Id == id).Include(e => e.Employees).Single();
        }
    }
}
