using System.Collections.Generic;
using System.Web.Mvc;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}