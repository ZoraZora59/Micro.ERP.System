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
        [Display(Name = "货单类型")]
        public string OrderType { get; set; }
        [Required]
        [Display(Name = "订货量")]
        public int GoodsQuantity { get; set; }
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


        public int FundsID { get; set; }
        public int ConfirmID { get; set; }
        public int GoodsResourceID { get; set; }
        [Required]
        public int ApplyUserID { get; set; }
        public int RejectedOrderID { get; set; }
    }
}
