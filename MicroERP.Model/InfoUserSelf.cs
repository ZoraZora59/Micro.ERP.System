using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroERP.Model
{
    public class InfoUserSelf
    {
        [Key]
        [Display(Name = "员工编号")]
        [Required]
        public int UserID { get; set; }
        [Display(Name = "姓名")]
        [Required]
        public string UserName { get; set; }
        [Display(Name = "手机号")]
        [Required]
        public string UserPhoneNumber { get; set; }
        [Display(Name = "联络地址")]
        [Required]
        public string UserAddress { get; set; }
        [Display(Name = "密码")]
        [Required]
        [MaxLength(64)]
        public string UserPassword { get; set; }
        [Display(Name = "E-mail")]
        [Required]
        public string UserEmail { get; set; }
        [Display(Name = "所属部门")]
        [Required]
        public string UserDepartment { get; set; }
        [Display(Name = "职位")]
        [Required]
        public string UserPosition { get; set; }
        [Display(Name = "预期薪资")]
        [Required]
        public decimal UserSalary { get; set; }
        [Display(Name = "在职状态")]
        [Required]
        public string UserStatus { get; set; }
        [Display(Name = "入职时间")]
        [Column(TypeName = "Date")]
        public DateTime OfferDate { get; set; }
    }
}
