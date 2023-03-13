using System.ComponentModel.DataAnnotations;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}