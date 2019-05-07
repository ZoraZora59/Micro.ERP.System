using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsRejectedOrder
    {
        [Key]
        [Display(Name = "重审编号")]
        [Required]
        public int RejectID { get; set; }
        [Display(Name = "重审状态")]
        [Required]
        public string RejectState { get; set; }
        [Display(Name = "备注信息")]
        [Required]
        public string RejectNote { get; set; }

        [Display(Name = "重审时间")]
        [Column(TypeName = "Date")]
        public DateTime RejectDate { get; set; }

        public int ConfirmID { get; set; }
        [Required]
        public int GoodsOrderID { get; set; }
        [Required]
        public int CheckUserID { get; set; }
    }
}
