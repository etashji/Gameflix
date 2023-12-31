﻿using Gameflix.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gameflix.Contexts
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("usersConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Gameflix.Areas.Cyberpunk2077.Models.Season1> Season1 { get; set; }
    }
}