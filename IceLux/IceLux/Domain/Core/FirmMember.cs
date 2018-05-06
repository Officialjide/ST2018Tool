namespace IceLux.Domain.Core
{
    public class FirmMember
    {
        public int FirmId { get; set; }
        public Firm Firm { get; set; }

        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public bool? AllowTaking { get; set; } //given right to do take? maybe should allow date base upto when!*/
        
    }
}
