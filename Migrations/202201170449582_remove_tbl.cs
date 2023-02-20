namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_tbl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registration_Form", "R_Address");
            DropColumn("dbo.Registration_Form", "R_Fields");
            DropColumn("dbo.Registration_Form", "R_ProfileStates");
            DropColumn("dbo.Registration_Form", "R_OtherDetails");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration_Form", "R_OtherDetails", c => c.String());
            AddColumn("dbo.Registration_Form", "R_ProfileStates", c => c.String());
            AddColumn("dbo.Registration_Form", "R_Fields", c => c.String());
            AddColumn("dbo.Registration_Form", "R_Address", c => c.String());
        }
    }
}
