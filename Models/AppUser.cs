using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Twitalike.Models {


    public class AppUser : IdentityUser {
        // one to many    AppUser  to   Message
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; } 
    }
}
