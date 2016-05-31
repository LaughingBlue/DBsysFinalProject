namespace DBsysFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reminders", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Reminders", "Datetime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reminders", "Datetime", c => c.String());
            AlterColumn("dbo.Reminders", "Title", c => c.String());
        }
    }
}
