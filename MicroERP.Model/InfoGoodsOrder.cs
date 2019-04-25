using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsOrder
    { 
        [Key]
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


        public virtual InfoFundsGoods Funds { get; set; }
        public virtual InfoGoodsConfirm GoodsConfirm { get; set; }
        public virtual InfoGoodsResource GoodsResource { get; set; }
        [Required]
        public virtual InfoUserSelf ApplyUser { get; set; }
        public virtual InfoGoodsRejectedOrder RejectedOrder { get; set; }
    }
}
