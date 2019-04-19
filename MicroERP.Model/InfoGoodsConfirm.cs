using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsConfirm
    {
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
        [Display(Name = "货单编号")]
        public int OrderID { get; set; }
        [Display(Name = "驳回单编号")]
        public int RejectID { get; set; }
        [Display(Name = "资金单编号")]
        public int FundsForGoodsID { get; set; }
    
        public virtual InfoUserSelf UserSelfInfo { get; set; }
        public virtual InfoGoodsOrder GoodsOrderInfo { get; set; }
        public virtual InfoGoodsRejectedOrder GoodsRejectedOrderInfo { get; set; }
        public virtual InfoFundsGoods InfoFundsGoods { get; set; }
    }
}
