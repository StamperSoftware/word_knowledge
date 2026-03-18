using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public sealed class AppUser:IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public static AppUser CreateAppUser(string email, string username, string firstName, string lastName) 
        {
            return new AppUser
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = username,
            };
        }

    }
}
