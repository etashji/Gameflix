using Gameflix.Areas.Cyberpunk2077.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gameflix.Contexts
{
    public class Cyberpunk2077Context : DbContext
    {
        public Cyberpunk2077Context() : base("cyberpunk2077Connection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Season1> Season1 { get; set; }

        public DbSet<Season2> Season2 { get; set; }
    }
}