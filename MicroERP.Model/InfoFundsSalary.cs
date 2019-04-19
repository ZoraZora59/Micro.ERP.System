using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoFundsSalary
    {
        [Key]
        [Required]
        [Display(Name = "工资单编号")]
        public int SalaryID { get; set; }
        [Required]
        [Display(Name = "基本工资")]
        public decimal BaseSalary { get; set; }
        [Required]
        [Display(Name = "绩效奖金")]
        public decimal PerformanceBonus { get; set; }
        [Required]
        [Display(Name = "实发工资")]
        public decimal RealWage { get; set; }
        [Column(TypeName = "Date")]
        [Display(Name = "派发时间")]
        public DateTime PayWagesDate { get; set; }

        [Display(Name = "违规记录编号")]
        public int RecordID { get; set; }
        [Required]
        [Display(Name = "员工编号")]
    
        public virtual InfoEmployeeViolation EmployeeViolationInfo { get; set; }
        public virtual InfoUserSelf UserSelfInfo { get; set; }
    }
}
