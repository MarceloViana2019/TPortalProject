using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TPortalProject.Data.Configurations;
using TPortalProject.Domain.Entities;

namespace TPortalProject.Data.Context
{
    public class TPortalProjectContext : DbContext
    {
        public TPortalProjectContext(DbContextOptions<TPortalProjectContext> option)
            : base(option) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
