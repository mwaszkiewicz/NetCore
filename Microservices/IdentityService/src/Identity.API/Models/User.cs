using Microsoft.AspNetCore.Identity;
using System;

namespace Identity.API.Models
{
    public class User : IdentityUser
    {
        public DateTime Birthday { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
