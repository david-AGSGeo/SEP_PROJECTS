namespace UTS_TFS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "firstName", c => c.String(nullable: true));
            AlterColumn("dbo.AspNetUsers", "lastName", c => c.String(nullable: true));
            AlterColumn("dbo.AspNetUsers", "phoneNo", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "phoneNo", c => c.String());
            AlterColumn("dbo.AspNetUsers", "lastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "firstName", c => c.String());
        }
    }
}
