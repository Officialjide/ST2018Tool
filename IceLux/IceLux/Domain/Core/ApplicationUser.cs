using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace IceLux.Domain.Core
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Subscriptions = new List<Subscription>();
            FirmMembers = new List<FirmMember>();
        }

        public string CustomerIdentifier { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<FirmMember> FirmMembers { get; set; }
    }
}
