namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img_col : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registration_Form", "R_Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registration_Form", "R_Image", c => c.String());
        }
    }
}
