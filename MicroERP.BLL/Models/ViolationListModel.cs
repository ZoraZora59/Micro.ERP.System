using MicroERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public class ViolationListModel
    {
        [Key]
        [Required]
        [Display(Name = "记录编号")]
        public int RecordID { get; set; }
        [Required]
        [Display(Name = "违规原因")]
        public string ViolateFor { get; set; }
        [Required]
        [Display(Name = "罚款金额")]
        public decimal FundsPunish { get; set; }
        [Display(Name = "记录更新时间")]
        public string RecordDate { get; set; }
        [Required]
        [Display(Name = "记录人编号")]
        public int ManagerID { get; set; }
        [Required]
        [Display(Name = "被执行人编号")]
        public int ReferID { get; set; }
        [Display(Name ="被执行人")]
        public string ReferName { get; set; }
        [Display(Name ="记录人")]
        public string ManagerName { get; set; }
    }
}
