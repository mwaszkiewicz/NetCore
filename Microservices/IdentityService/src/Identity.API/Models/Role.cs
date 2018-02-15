using Microsoft.AspNetCore.Identity;

namespace Identity.API.Models
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
