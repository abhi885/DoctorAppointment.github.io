namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbl_new : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookingOnlines", "bo_time", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookingOnlines", "bo_time", c => c.Int(nullable: false));
        }
    }
}
