using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public static class TypesOfGoodsModel
    {
        public static List<string> orderType = new List<string>() { "进货" , "出货" };
        public static List<string> confirmState = new List<string>() { "待确认", "已确认", "已处理" };
        public static List<string> rejectState = new List<string>() { "待修改", "待审批", "已处理" };
    }
}
