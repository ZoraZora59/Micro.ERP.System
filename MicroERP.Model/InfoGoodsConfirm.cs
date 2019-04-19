using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsConfirm
    {
        [Key]
        [Required]
        [Display(Name = "确认单编号")]
        public int ConfirmID { get; set; }
        [Required]
        [Display(Name = "确认类型")]
        public string ConfirmType { get; set; }
        [Required]
        [Display(Name = "备注信息")]
        public string ConfirmNote { get; set; }
        [Required]
        [Display(Name = "本次确认时间")]
        [Column(TypeName = "Date")]
        public DateTime ConfirmDate { get; set; }

        [Required]
        [Display(Name = "检查员编号")]
        public int UserID { get; set; }
        [Display(Name = "目标单编号")]
        public int ConfirmOrderID { get; set; }
    
        public virtual InfoUserSelf UserSelfInfo { get; set; }
    }
}
