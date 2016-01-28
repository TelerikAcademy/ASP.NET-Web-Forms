namespace NewsSystem.Data.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}
