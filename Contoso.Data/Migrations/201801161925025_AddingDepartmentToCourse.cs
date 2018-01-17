namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDepartmentToCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Credits = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Department_Id" });
            DropTable("dbo.Courses");
        }
    }
}
