using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
    public class ViewUserSelf
    {
        [Display(Name ="Ա�����")]
        public int UserID { get; set; }
        [Display(Name ="����")]
        public string UserName { get; set; }
        [Display(Name = "�ֻ���")]
        public string PhoneNumber { get; set; }
        [Display(Name = "��ϵ��ַ")]
        public string Address { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Display(Name = "����")]
        public string UserPassword { get; set; }
    }
}
