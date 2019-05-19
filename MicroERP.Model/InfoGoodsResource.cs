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
        [Display(Name = "货物名")]
        public string GoodsName { get; set; }
        [Required]
        [Display(Name = "存货量")]
        public int GoodsQuantity { get; set; }
        [Required]
        [Display(Name = "计数单位")]
        public string GoodsCountingUnit { get; set; }
        [Required]
        [Display(Name = "单价")]
        public decimal GoodsUnitPrice { get; set; }
        [Required]
        [Display(Name = "货源")]
        public string GoodsFrom { get; set; }
    }
}
