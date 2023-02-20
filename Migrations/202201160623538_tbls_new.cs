namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbls_new : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookingOnlines", "bo_date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookingOnlines", "bo_date", c => c.Int(nullable: false));
        }
    }
}
