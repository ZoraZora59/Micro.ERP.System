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

    
        [Required]
        public int UserID { get; set; }
    }
}
