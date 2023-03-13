using System.ComponentModel.DataAnnotations;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}