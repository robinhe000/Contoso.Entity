namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDbMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Email = c.String(),
                        City = c.String(),
                        DateBirth = c.DateTime(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
