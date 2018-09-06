namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gigs", "DateTime", c => c.DateTime());
        }
    }
}
