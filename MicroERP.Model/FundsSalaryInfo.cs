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
    
    public partial class FundsSalaryInfo
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal PerformanceBonus { get; set; }
        public Nullable<int> ViolationRecordID { get; set; }
        public decimal RealWage { get; set; }
        public System.DateTime PayWagesDate { get; set; }
    
        public virtual EmployeeViolationInfo EmployeeViolationInfo { get; set; }
        public virtual UserSelfInfo UserSelfInfo { get; set; }
    }
}
