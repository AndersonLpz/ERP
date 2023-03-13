using System.Collections.Generic;

namespace XRM.Infra.CrossCutting.Identity._2_Model
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}