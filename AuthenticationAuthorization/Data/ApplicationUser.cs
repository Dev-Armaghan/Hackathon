using Microsoft.AspNetCore.Identity;

namespace AuthenticationAuthorization.Data
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public DateTime CareerStarted { get; set; }
    }
}
