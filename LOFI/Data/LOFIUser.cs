using Microsoft.AspNetCore.Identity;

namespace LOFI.Data
{
    public class LOFIUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
