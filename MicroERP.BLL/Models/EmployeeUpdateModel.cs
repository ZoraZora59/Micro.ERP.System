using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public class EmployeeUpdateModel
    {
        [Display(Name = "更新记录编号")]
        public int UpdateID { get; set; }
        [Display(Name = "更新时间")]
        public string UpdateTime { get; set; }
        [Display(Name = "更新类型")]
        public string UpdateType { get; set; }
        [Display(Name = "更新前")]
        public string UpdateFrom { get; set; }
        [Display(Name = "更新后")]
        public string UpdateInto { get; set; }
        [Display(Name = "备注信息")]
        public string UpdateInformation { get; set; }
        [Display(Name = "修改负责人")]
        public string UpdateBy { get; set; }
        [Display(Name = "修改负责人编号")]
        public int UpdateByID { get; set; }
        [Display(Name = "被改动员工")]
        public string User { get; set; }
        [Display(Name = "被改动员工编号")]
        public int UserID { get; set; }
    }
}
