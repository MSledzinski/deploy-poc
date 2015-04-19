namespace Poc.Deploy.WriteWinService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        Name = c.String(),
                        Employer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employer", t => t.Employer_Id)
                .Index(t => t.Employer_Id);
            
            CreateTable(
                "dbo.Employer",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Employer_Id", "dbo.Employer");
            DropIndex("dbo.Employee", new[] { "Employer_Id" });
            DropTable("dbo.Employer");
            DropTable("dbo.Employee");
        }
    }
}
