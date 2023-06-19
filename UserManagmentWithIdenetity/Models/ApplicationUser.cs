using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace UserManagmentWithIdenetity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [System.ComponentModel.DataAnnotations.Required, MaxLength(120)]
        public string FirstName { get; set; } = null!;
        [System.ComponentModel.DataAnnotations.Required, MaxLength(120)]
        public string LastName { get; set; } =  null!;

        public byte[]? ProfilePicture { get; set; } 
    }
}
