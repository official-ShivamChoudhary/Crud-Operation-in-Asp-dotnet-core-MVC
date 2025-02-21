using System.ComponentModel.DataAnnotations;

namespace Crud_Operation_in_mvc.Models
{
    public class Registrartion
    {
        [Key]
        public int RegistrationId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}