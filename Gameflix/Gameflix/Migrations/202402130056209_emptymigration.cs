namespace Gameflix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emptymigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Season2",
                c => new
                    {
                        Season2Id = c.Int(nullable: false, identity: true),
                        episodeNumber = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Video = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Season2Id);
            
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 16),
                        Password = c.String(nullable: false, maxLength: 16),
                        confirmPassword = c.String(nullable: false),
                        salt = c.String(),
                        hashedPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            DropTable("dbo.Season2");
        }
    }
}
