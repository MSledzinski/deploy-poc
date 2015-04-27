namespace Poc.Deploy.WriteWinService.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Poc.Deploy.CommonModels.Domain;
    using Poc.Deploy.WriteWinService.DataAccess;

    public sealed class Configuration : DbMigrationsConfiguration<EmploymentDataDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(EmploymentDataDbContext context)
        {
            if (context.Employers.Any())
            {
                return;
            }

            var employer = new Employer(1, "employer1");
            context.Employers.Add(employer);

            var re = context.SaveChanges();
            base.Seed(context);
        }
    }
}
