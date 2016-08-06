namespace FirstFullStackSocialMedia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendences",
                c => new
                    {
                        GigId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                        user_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GigId, t.AttendeeId })
                .ForeignKey("dbo.Gigs", t => t.GigId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.GigId)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendences", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendences", "GigId", "dbo.Gigs");
            DropIndex("dbo.Attendences", new[] { "user_Id" });
            DropIndex("dbo.Attendences", new[] { "GigId" });
            DropTable("dbo.Attendences");
        }
    }
}
