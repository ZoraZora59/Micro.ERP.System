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
        [Display(Name = "��������")]
        public string OrderType { get; set; }
        [Required]
        [Display(Name = "������")]
        public int GoodsQuantity { get; set; }
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


        public int FundsID { get; set; }
        public int ConfirmID { get; set; }
        public int GoodsResourceID { get; set; }
        [Required]
        public int ApplyUserID { get; set; }
        public int RejectedOrderID { get; set; }
    }
}
