namespace ControlNomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        City = c.String(),
                        Adress = c.String(),
                        Subscription = c.Int(nullable: false),
                        BuyDate = c.DateTime(nullable: false),
                        CardNumber = c.String(),
                        SummWallet = c.Int(nullable: false),
                        Journal_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Journals", t => t.Journal_Id)
                .Index(t => t.Journal_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Journal_Id", "dbo.Journals");
            DropIndex("dbo.Users", new[] { "Journal_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Journals");
        }
    }
}
