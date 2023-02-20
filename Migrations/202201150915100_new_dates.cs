namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_dates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookingOnlines", "bo_name", c => c.String());
            AlterColumn("dbo.BookingOnlines", "bo_phone", c => c.String());
            AlterColumn("dbo.BookingOnlines", "bo_Speciality", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookingOnlines", "bo_Speciality", c => c.Int(nullable: false));
            AlterColumn("dbo.BookingOnlines", "bo_phone", c => c.Int(nullable: false));
            AlterColumn("dbo.BookingOnlines", "bo_name", c => c.Int(nullable: false));
        }
    }
}
