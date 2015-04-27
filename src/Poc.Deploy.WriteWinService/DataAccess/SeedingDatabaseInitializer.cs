namespace Poc.Deploy.WriteWinService.DataAccess
{
    using System.Data.Entity;

    using Poc.Deploy.WriteWinService.Migrations;

    public class SeedingDatabaseInitializer : MigrateDatabaseToLatestVersion<EmploymentDataDbContext, Configuration>
    {
    }
}
