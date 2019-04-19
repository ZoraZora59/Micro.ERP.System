using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoTotalAssets
    {
        [Key]
        [Required]
        [Display(Name = "资产变化记录编号")]
        public int AssetsUpdateID { get; set; }
        [Required]
        [Display(Name = "总资产")]
        public decimal TotalAssets { get; set; }
        [Display(Name = "更新时间")]
        public DateTime UpdateTime { get; set; }
        [Required]
        [Display(Name = "相关记录类型")]
        public string AttachedType { get; set; }
        [Required]
        [Display(Name = "相关记录编号")]
        public int AttachedID { get; set; }
    }
}
