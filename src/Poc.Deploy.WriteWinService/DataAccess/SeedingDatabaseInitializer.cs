namespace Poc.Deploy.WriteWinService.DataAccess
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    using Poc.Deploy.CommonModels.Domain;

    public class SeedingDatabaseInitializer : MigrateDatabaseToLatestVersion<EmploymentDataDbContext, Migrations.Configuration>
    {
        public override void InitializeDatabase(EmploymentDataDbContext context)
        {

            base.InitializeDatabase(context);
        }
    }
}