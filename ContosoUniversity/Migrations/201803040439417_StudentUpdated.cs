namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
            AddColumn("dbo.Person", "Gpa", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Email");
        }
    }
}
