using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.Model
{
    public class ViewUserAsEmployee
    {
        [Display(Name = "员工编号")]
        public int UserID { get; set; }
        [Display(Name ="姓名")]
        public string UserName { get; set; }
        [Display(Name ="所在部门")]
        public string UserDepartment { get; set; }
        [Display(Name ="职位")]
        public string UserPosition { get; set; }
        [Display(Name ="在职状态 ")]
        public string UserStatus { get; set; }
        [Display(Name ="预期薪资")]
        public decimal UserSalary { get; set; }
    }
}