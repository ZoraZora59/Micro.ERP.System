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
        [Display(Name = "�������")]
        public int OrderID { get; set; }
        [Required]
        [Display(Name = "������")]
        public long GoodsQuantity { get; set; }
        [Required]
        [Display(Name = "����Ŀ��")]
        public string GoodsTarget { get; set; }
        [Required]
        [Display(Name = "���ﵥ��")]
        public int GoodsUnitPrice { get; set; }
        [Display(Name = "�µ�ʱ��")]
        [Column(TypeName = "Date")]
        public DateTime OrderTime { get; set; }
        [Display(Name = "��ע��Ϣ")]
        public string SaleNote { get; set; }


        public virtual InfoFundsGoods Funds { get; set; }
        public virtual InfoGoodsConfirm GoodsConfirm { get; set; }
        public virtual InfoGoodsResource GoodsResource { get; set; }
        [Required]
        public virtual InfoUserSelf ApplyUser { get; set; }
        public virtual InfoGoodsRejectedOrder RejectedOrder { get; set; }
    }
}
