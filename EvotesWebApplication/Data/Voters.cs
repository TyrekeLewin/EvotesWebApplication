using Microsoft.AspNetCore.Identity;

namespace EvotesWebApplication.Data
{
    public class Voters : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TRN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegisteredDate { get; set;}
    }
}
