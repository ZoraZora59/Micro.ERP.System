using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.Model
{
    public class ViewUserAsEmployee
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserDepartment { get; set; }
        public string UserPosition { get; set; }
        public string UserStatus { get; set; }
    }
}