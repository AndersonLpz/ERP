using System.ComponentModel.DataAnnotations;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome da Role")]
        public string Name { get; set; }
    }
}
