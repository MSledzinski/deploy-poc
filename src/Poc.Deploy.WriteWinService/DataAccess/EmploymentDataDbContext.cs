namespace Poc.Deploy.WriteWinService.DataAccess
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Poc.Deploy.CommonModels.Domain;

    public class EmploymentDataDbContext : DbContext
    {
        public EmploymentDataDbContext()
            : base("EmployConnectionString")
        {
        }

        public IDbSet<Employer> Employers { get; set; }

        public IDbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder
                .Properties()
                .Where(p => p.Name == "Id")
                .Configure(
                    p =>
                        {
                            p.IsKey();
                            p.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                        });
        }
    }
}