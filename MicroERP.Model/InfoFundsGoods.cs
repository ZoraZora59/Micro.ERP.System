using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoFundsGoods
    {
        [Required]
        [Display(Name = "货流资金编号")]
        public int FundsForGoodsID { get; set; }
        [Required]
        [Display(Name = "资金状态")]
        public string FundsState { get; set; }
        [Required]
        [Display(Name = "资金变化值")]
        public decimal FundsUpdate { get; set; }
        [Display(Name = "最后确认时间")]
        [Column(TypeName = "Date")]
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        [Display(Name = "备注")]
        public string FundsNote { get; set; }

        [Display(Name = "确认人编号")]
        public int UserID { get; set; }
        [Display(Name = "确认单编号")]
        public int ConfirmID { get; set; }
        [Display(Name = "货单编号")]
        [Required]
        public int OrderID { get; set; }

        public virtual InfoUserSelf UserSelfInfo { get; set; }
        public virtual InfoGoodsConfirm GoodsConfirmInfo { get; set; }
        public virtual InfoGoodsOrder GoodsOrderInfo { get; set; }
    }
}
