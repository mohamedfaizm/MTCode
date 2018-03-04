namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdatedStudent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "CreditsEarned", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "CreditsEarned", c => c.Int());
        }
    }
}
