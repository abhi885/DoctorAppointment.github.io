namespace DoctorWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin Registration",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminFirstName = c.String(nullable: false),
                        AdminLastName = c.String(nullable: false),
                        AdminEmail = c.String(nullable: false),
                        AdminPassword = c.String(nullable: false),
                        AdminConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.BookingOnlines",
                c => new
                    {
                        bo_id = c.Int(nullable: false, identity: true),
                        bo_name = c.Int(nullable: false),
                        bo_phone = c.Int(nullable: false),
                        bo_date = c.Int(nullable: false),
                        bo_time = c.Int(nullable: false),
                        bo_Speciality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bo_id);
            
            CreateTable(
                "dbo.Contact Form",
                c => new
                    {
                        C_id = c.Int(nullable: false, identity: true),
                        C_FirstName = c.String(nullable: false, maxLength: 20),
                        C_LasttName = c.String(nullable: false, maxLength: 20),
                        C_Email = c.String(nullable: false),
                        C_Subject = c.String(nullable: false),
                        C_Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.C_id);
            
            CreateTable(
                "dbo.PatientQueries",
                c => new
                    {
                        Qid = c.Int(nullable: false, identity: true),
                        Qname = c.String(nullable: false),
                        QEmail = c.String(nullable: false),
                        Qcontact = c.String(nullable: false),
                        Qquestion = c.String(nullable: false),
                        Drid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Qid);
            
            CreateTable(
                "dbo.Registration_Form",
                c => new
                    {
                        rid = c.Int(nullable: false, identity: true),
                        R_FirstName = c.String(nullable: false),
                        R_LastName = c.String(nullable: false),
                        R_Gender = c.String(nullable: false),
                        R_Country = c.String(),
                        R_State = c.String(),
                        R_City = c.String(),
                        R_Contact = c.String(nullable: false),
                        R_Email = c.String(nullable: false),
                        R_Address = c.String(),
                        R_Fields = c.String(),
                        R_Qualification = c.String(),
                        R_Specialization = c.String(),
                        R_WorkExperience = c.String(),
                        R_AchievementDetails = c.String(),
                        R_Password = c.String(nullable: false),
                        R_ConfirmPassword = c.String(nullable: false),
                        R_ProfileStates = c.String(),
                        R_JoiningDate = c.String(),
                        R_OtherDetails = c.String(),
                        R_Image = c.String(),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registration_Form");
            DropTable("dbo.PatientQueries");
            DropTable("dbo.Contact Form");
            DropTable("dbo.BookingOnlines");
            DropTable("dbo.Admin Registration");
        }
    }
}
