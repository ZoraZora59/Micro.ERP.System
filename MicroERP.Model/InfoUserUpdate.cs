using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoUserUpdate
    {
        [Key]
        [Required]
        [Display(Name = "更新记录编号")]
        public int UpdateID { get; set; }
        [Display(Name = "更新时间")]
        [Column(TypeName = "Date")]
        public DateTime UpdateTime { get; set; }
        [Required]
        [Display(Name = "更新类型")]
        public string UpdateType { get; set; }
        [Required]
        [Display(Name = "更新前")]
        public string UpdateFrom { get; set; }
        [Required]
        [Display(Name = "更新后")]
        public string UpdateInto { get; set; }
        [Display(Name = "备注信息")]
        public string UpdateInformation { get; set; }
        [Required]
        [Display(Name ="操作员标记")]
        public int UpdateBy { get; set; }
        [Required]
        public int UserID { get; set; }
    }
}
