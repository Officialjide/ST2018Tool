using System;
using System.Collections.Generic;

namespace IceLux.Domain.Core
{
    public class Firm
    {
        public Firm()
        {
            Items = new List<Item>();
            Centers = new List<Center>();
            FirmMembers = new List<FirmMember>();           
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string OwnerId { get; set; } // user table
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ApproveDate { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<FirmMember> FirmMembers { get; set; }
    }
}
