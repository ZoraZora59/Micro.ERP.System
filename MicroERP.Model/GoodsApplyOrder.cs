//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroERP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsApplyOrder
    {
        public int 订单号 { get; set; }
        public int 货物号 { get; set; }
        public string 货物名 { get; set; }
        public long 订单货量 { get; set; }
        public string 货物目标 { get; set; }
        public int 单价 { get; set; }
        public int 销售员编号 { get; set; }
        public string 销售员姓名 { get; set; }
        public Nullable<System.DateTime> 下单时间 { get; set; }
    }
}
