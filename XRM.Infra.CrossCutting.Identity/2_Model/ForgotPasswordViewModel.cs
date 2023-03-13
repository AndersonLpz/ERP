using System.ComponentModel.DataAnnotations;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
