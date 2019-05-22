using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroERP.Model;
namespace MicroERP.BLL.Models
{
    public class GoodsListModel
    {
        [Display(Name = "编号")]
        public int OrderID { get; set; }
        [Display(Name ="货单类型")]
        public string OrderType { get; set; }
        [Display(Name = "订货量")]
        public int GoodsQuantity { get; set; }
        [Display(Name = "货流目标")]
        public string GoodsTarget { get; set; }
        [Display(Name = "货物单价")]
        public decimal GoodsUnitPrice { get; set; }
        [Display(Name = "下单时间")]
        public string OrderTime { get; set; }
        [Display(Name = "备注信息")]
        public string SaleNote { get; set; }

        [Display(Name = "资金单记录")]
        public string FundsID { get; set; }
        [Display(Name = "确认单记录")]
        public string ConfirmID { get; set; }
        [Display(Name = "货物库存记录编号")]
        public int GoodsResourceID { get; set; }

        [Display(Name = "货物库存记录名称")]
        public string GoodsResourceName { get; set; }
        [Display(Name = "申请人编号")]
        public int ApplyUserID { get; set; }
        [Display(Name = "申请人姓名")]
        public string ApplyUserName { get; set; }
        [Display(Name = "驳回记录")]
        public string RejectedOrderID { get; set; }
    }
}
