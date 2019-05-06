using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
    public class ViewUserSelf
    {
        [Display(Name ="员工编号")]
        public int UserID { get; set; }
        [Display(Name ="姓名")]
        public string UserName { get; set; }
        [Display(Name = "手机号")]
        public string PhoneNumber { get; set; }
        [Display(Name = "联系地址")]
        public string Address { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Display(Name = "密码")]
        public string UserPassword { get; set; }
    }
}
