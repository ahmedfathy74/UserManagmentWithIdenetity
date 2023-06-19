using System.ComponentModel.DataAnnotations;

namespace UserManagmentWithIdenetity.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; } = null!;
    }
}
