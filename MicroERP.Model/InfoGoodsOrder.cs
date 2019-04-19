using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class InfoGoodsOrder
    {
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

        [Required]
        [Display(Name = "�����˱��")]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "������")]
        public int GoodsID { get; set; }
        [Display(Name = "ȷ�ϵ����")]
        public int ConfirmID { get; set; }

        public virtual ICollection<InfoFundsGoods> FundsGoodsInfo { get; set; }
        public virtual ICollection<InfoGoodsConfirm> GoodsConfirmInfo { get; set; }
        public virtual InfoGoodsConfirm GoodsConfirmInfo1 { get; set; }
        public virtual InfoGoodsResource GoodsResourceInfo { get; set; }
        public virtual InfoUserSelf UserSelfInfo { get; set; }
        public virtual ICollection<InfoGoodsRejectedOrder> GoodsRejectedOrderInfo { get; set; }
    }
}
