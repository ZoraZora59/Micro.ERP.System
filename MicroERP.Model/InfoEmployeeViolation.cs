using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroERP.Model
{
    public class InfoEmployeeViolation
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
        [Column(TypeName = "Date")]
        public DateTime RecordDate { get; set; }
        [Required]
        [Display(Name ="记录人编号")]
        public int ManagerID { get; set; }
        [Required]
        [Display(Name ="被执行人编号")]
        public int ReferID { get; set; }
    }
}
