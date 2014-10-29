namespace OMAPDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "IsEULA", c => c.Boolean(nullable: false));
            DropColumn("dbo.Enrollments", "EULA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "EULA", c => c.Boolean(nullable: false));
            DropColumn("dbo.Enrollments", "IsEULA");
        }
    }
}
