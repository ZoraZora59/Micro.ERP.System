using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
    
    public class ViewUserLogin
    {
        [Display(Name = "‘±π§±‡∫≈")]
        public int UserID { get; set; }
        [Display(Name ="√‹¬Î")]
        public string UserPassword { get; set; }
    }
}
