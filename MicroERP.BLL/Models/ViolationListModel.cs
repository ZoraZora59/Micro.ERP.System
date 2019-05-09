using MicroERP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.BLL.Models
{
    public class ViolationListModel:InfoEmployeeViolation
    {
        [Display(Name ="被执行人")]
        public string ReferName { get; set; }
        [Display(Name ="记录人")]
        public string ManagerName { get; set; }
    }
}
