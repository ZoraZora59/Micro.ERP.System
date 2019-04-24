using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public class UserLoginForm
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        [StringLength(maximumLength: 16, MinimumLength = 4, ErrorMessage = "密码必须在4~16位之间")]
        //[RegularExpression("[\\u4e00-\\u9fa5]", ErrorMessage = "密码不能使用中文")]
        public string Password { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "请检查验证码，长度为4位")]
        public string Code { get; set; }
    }
}
