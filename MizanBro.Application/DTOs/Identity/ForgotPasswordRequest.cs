using System.ComponentModel.DataAnnotations;

namespace MizanBro.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}