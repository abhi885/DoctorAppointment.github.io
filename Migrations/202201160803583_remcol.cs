namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remcol : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registration_Form", "R_Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration_Form", "R_Image", c => c.String(nullable: false));
        }
    }
}
