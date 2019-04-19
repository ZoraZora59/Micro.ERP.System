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

        [Display(Name = "发起重审的确认单号")]
        [Required]
        public string ConfirmID { get; set; }
        [Display(Name = "货单编号")]
        [Required]
        public string OrderID { get; set; }
        [Display(Name = "操作员编号")]
        [Required]
        public string UserID { get; set; }
        [Display(Name = "重审时间")]
        [Column(TypeName = "Date")]
        public DateTime RejectDate { get; set; }

        public virtual InfoGoodsConfirm GoodsConfirmInfo { get; set; }
        public virtual InfoGoodsOrder GoodsOrderInfo { get; set; }
        public virtual InfoUserSelf UserSelfInfo { get; set; }
    }
}
