using Microsoft.AspNetCore.Identity;

namespace ProtectedDataWasmExample.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ProtectedPersonalData]
        [PersonalData]
        public string Firstname { get; set; }
        [ProtectedPersonalData]
        [PersonalData]
        public string Lastname { get; set; }
    }
}
