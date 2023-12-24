namespace Gameflix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cyberpunk2077Season1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Season1",
                c => new
                    {
                        Season1Id = c.Int(nullable: false, identity: true),
                        episodeNumber = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Video = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Season1Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Season1");
        }
    }
}
