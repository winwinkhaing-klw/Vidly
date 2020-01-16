namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removemembershiptype : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembsershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembsershipTypeId", c => c.Int(nullable: false));
        }
    }
}
