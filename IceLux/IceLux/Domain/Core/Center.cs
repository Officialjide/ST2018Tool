using System.Collections.Generic;

namespace IceLux.Domain.Core
{
    public class Center
    {
        public Center()
        {
            Takes = new List<Take>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int FirmId { get; set; }
        public virtual Firm Firm { get; set; }
        public bool IsDefault { get; set; }
        public int? ParentCenterId { get; set; }
        public bool IsActive { get; set; }
        public virtual Center ParentCenter { get; set; }
        public ICollection<Center> Children { get; set; }

        public virtual ICollection<Take> Takes { get; set; }

        /*

modelbuilder.Entity<Center>().HasOptional(b=>b.ParentCenter )
                                  .WithMany(b=>b.Children )
                                  .HasForeignKey(b=>b.ParentCenterId);

        modelBuilder.Entity<Center>().HasOne(s => s.Centers).WithMany().HasForeignKey(e => e.ParentCenterId)
                                  */
    }
}
