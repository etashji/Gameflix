﻿namespace Gameflix.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Season1");
        }
    }
}
