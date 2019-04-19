using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsResource
    {
        [Key]
        [Required]
        [Display(Name = "货物编号")]
        public int GoodsID { get; set; }
        [Required]
        [Display(Name = "货单名")]
        public string GoodsName { get; set; }
        [Required]
        [Display(Name = "存货量")]
        public long GoodsQuantity { get; set; }
        [Required]
        [Display(Name = "计数单位")]
        public string GoodsCountingUnit { get; set; }
        [Required]
        [Display(Name = "单价")]
        public int GoodsUnitPrice { get; set; }
        [Required]
        [Display(Name = "货源")]
        public string GoodsFrom { get; set; }
    
        public virtual ICollection<InfoGoodsOrder> GoodsOrderInfo { get; set; }
    }
}
