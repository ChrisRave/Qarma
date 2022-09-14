using System.ComponentModel.DataAnnotations;

namespace ProjetQarma.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }   
        [Required]
        public string NewPassword { get; set; }

        [Required]
        public string NewPasswordConfirmation { get; set; }

        public int userID { get; set; }
    }
}
