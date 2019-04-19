using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsOrder
    {
        [Required]
        [Display(Name = "货单编号")]
        public int OrderID { get; set; }
        [Required]
        [Display(Name = "订货量")]
        public long GoodsQuantity { get; set; }
        [Required]
        [Display(Name = "货流目标")]
        public string GoodsTarget { get; set; }
        [Required]
        [Display(Name = "货物单价")]
        public int GoodsUnitPrice { get; set; }
        [Display(Name = "下单时间")]
        [Column(TypeName = "Date")]
        public DateTime OrderTime { get; set; }
        [Display(Name = "备注信息")]
        public string SaleNote { get; set; }

        [Required]
        [Display(Name = "申请人编号")]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "货物编号")]
        public int GoodsID { get; set; }
        [Display(Name = "确认单编号")]
        public int ConfirmID { get; set; }

        public virtual ICollection<InfoFundsGoods> FundsGoodsInfo { get; set; }
        public virtual ICollection<InfoGoodsConfirm> GoodsConfirmInfo { get; set; }
        public virtual InfoGoodsConfirm GoodsConfirmInfo1 { get; set; }
        public virtual InfoGoodsResource GoodsResourceInfo { get; set; }
        public virtual InfoUserSelf UserSelfInfo { get; set; }
        public virtual ICollection<InfoGoodsRejectedOrder> GoodsRejectedOrderInfo { get; set; }
    }
}
