using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
    
    public class ViewUserLogin
    {
        [Display(Name = "Ա�����")]
        public int UserID { get; set; }
        [Display(Name ="����")]
        public string UserPassword { get; set; }
    }
}
