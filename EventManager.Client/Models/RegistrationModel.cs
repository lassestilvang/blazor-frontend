
using System.ComponentModel.DataAnnotations;

namespace EventManager.Client.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Ticket Type.")]
        public string TicketType { get; set; } = "General";
    }
}
