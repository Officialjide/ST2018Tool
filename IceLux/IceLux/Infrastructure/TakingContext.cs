using IceLux.Domain.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IceLux.Infrastructure
{
    public class TakingContext : IdentityDbContext //: IdentityDbContext <ApplicationUser> 
    {
        public TakingContext(DbContextOptions options) : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Take> Takes { get; set; }
        public DbSet<TakeDetail> TakeDetails { get; set; }
        public DbSet<FirmMember> FirmMembers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Center>().HasOptional(b => b.ParentCenter)
                                  .WithMany(b => b.Children)
                                  .HasForeignKey(b => b.ParentCenterId);
            
            */
            modelBuilder.Entity<FirmMember>().HasKey(fm => new { fm.FirmId, fm.UserId });
            modelBuilder.Entity<Take>().HasOne<Center>(c => c.Center).WithMany(t => t.Takes).HasForeignKey(c => c.CenterId);
            modelBuilder.Entity<Item>().HasOne<Firm>(f => f.Firm).WithMany(i => i.Items).HasForeignKey(f => f.FirmId);
            modelBuilder.Entity<Center>().HasOne<Firm>(f => f.Firm).WithMany(ct => ct.Centers).HasForeignKey(c => c.FirmId);
            base.OnModelCreating(modelBuilder);

        }
    }
}
