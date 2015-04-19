namespace Poc.Deploy.WriteWinService.Migrations
{
    using System.Data.Entity.Migrations;

    using Poc.Deploy.CommonModels.Domain;
    using Poc.Deploy.WriteWinService.DataAccess;

    public sealed class Configuration : DbMigrationsConfiguration<EmploymentDataDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmploymentDataDbContext context)
        {
            var employer = new Employer(1, "employer1");
            context.Employers.Add(employer);

            var re = context.SaveChanges();
            base.Seed(context);
        }
    }
}
