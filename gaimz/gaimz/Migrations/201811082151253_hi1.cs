namespace gaimz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hi1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblWishlists", "userId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblWishlists", "userId", c => c.Int());
        }
    }
}
