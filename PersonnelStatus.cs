using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroERP.Model
{
	public enum Status
	{
		即将入职,
		在职,
		即将离职,
		离职
	}
	public enum Department
	{
		销售部,
		人事部,
		审核部,
		财务部,
		运营部,
		决策部
	}
	public class PersonnelStatus
	{
		[Display(Name = "员工编号")]
		public int PersonnelID { get; set; }
		[Display(Name = "密码")]
		public string Password { get; set; }
		[Display(Name = "姓名")]
		public string Name { get; set; }
		[Display(Name = "所在部门")]
		public Department Department { get; set; }
		[Display(Name="职位")]
		public string Position { get; set; }
		[Display(Name = "人事状态")]
		public Status Status { get; set; }
		[Display(Name = "月薪")]
		public int Salary { get; set; }
		[Display(Name = "人事备注")]
		public string Note { get; set; }
		[Display(Name = "入职时间")]
		public DateTime EntryTime{ get; set; }
		[Display(Name = "最后更新时间")]
		public DateTime UpdateTime { get; set; }
	}
}
