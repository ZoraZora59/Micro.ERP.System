using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MicroERP.Model
{
    public class ViewGoodsConfirm
    {
        public int 订单号 { get; set; }
        public int 确认号 { get; set; }
        public int 货物号 { get; set; }
        public string 货物名 { get; set; }
        public long 订单货量 { get; set; }
        public string 货物目标 { get; set; }
        public int 单价 { get; set; }
        public int 销售员编号 { get; set; }
        public Nullable<System.DateTime> 下单时间 { get; set; }
        public string 订单备注 { get; set; }
        public string 确认类型 { get; set; }
        public string 确认备注 { get; set; }
        public Nullable<System.DateTime> 确认时间 { get; set; }
        public string 销售员姓名 { get; set; }
        public string 确认员姓名 { get; set; }
    }
}
