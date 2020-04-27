namespace PlacementManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        SalaryPackage = c.Long(nullable: false),
                        Location = c.String(nullable: false),
                        CutoffPercentage = c.Int(nullable: false),
                        DateOfDrive = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        loginId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.loginId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        BranchName = c.String(nullable: false),
                        GraduationYear = c.DateTime(nullable: false),
                        Class10thMarks = c.Int(nullable: false),
                        Class12thMarks = c.Int(nullable: false),
                        CurrentCgpa = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Logins");
            DropTable("dbo.Companies");
        }
    }
}
