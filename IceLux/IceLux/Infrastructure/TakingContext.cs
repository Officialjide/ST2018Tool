using IceLux.Domain.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IceLux.Infrastructure
{
    public class TakingContext : IdentityDbContext <ApplicationUser> 
    {
        public TakingContext(DbContextOptions options) : base(options)
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //WINCORE-PG add-migration InitialSchema
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
            modelBuilder.Entity<Center>().HasOne(s => s.ParentCenter).WithMany().HasForeignKey(e => e.ParentCenterId);
            modelBuilder.Entity<FirmMember>().HasKey(fm => new { fm.FirmId, fm.UserId });
            modelBuilder.Entity<Take>().HasOne<Center>(c => c.Center).WithMany(t => t.Takes).HasForeignKey(c => c.CenterId);
            modelBuilder.Entity<Item>().HasOne<Firm>(f => f.Firm).WithMany(i => i.Items).HasForeignKey(f => f.FirmId);
            modelBuilder.Entity<Center>().HasOne<Firm>(f => f.Firm).WithMany(ct => ct.Centers).HasForeignKey(c => c.FirmId);
            modelBuilder.Entity<TakeDetail>().HasOne(t => t.Take).WithMany(t => t.TakeDetails).OnDelete(DeleteBehavior.Restrict);
                
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new FirmConfiguration()); 

        }
    }
}
