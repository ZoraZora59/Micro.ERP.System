using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public static class EmployeeResourceModel
    {
        public static List<string> Position = new List<string>() { "办事员", "销售员","审核员", "经理", "总监" };
        public static List<string> Department = new List<string>() { "财务部", "综合管理部", "市场部"};
    }
}
