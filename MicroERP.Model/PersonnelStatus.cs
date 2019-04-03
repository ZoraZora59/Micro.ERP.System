using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class PersonnelStatus
	{
		[Display(Name = "员工编号")]
		public int PersonnelID { get; set; }
		[Display(Name = "密码")]
		public string Password { get; set; }
		[Display(Name = "姓名")]
		public string Name { get; set; }
		[Display(Name = "所在部门")]
		public string Department { get; set; }
		[Display(Name="职位")]
		public string Position { get; set; }
		[Display(Name = "人事状态")]
		public string Status { get; set; }
		[Display(Name = "月薪")]
		public int Salary { get; set; }
		[Display(Name = "人事备注")]
		public string Note { get; set; }
		[Display(Name = "入职时间")]
		public DateTime EntryTime{ get; set; }
		[Display(Name = "最后更新时间")]
		public DateTime UpdateTime { get; set; }

		public virtual ICollection<FundState> FundState { get; set; }
		public virtual ICollection<GoodsState> GoodsState { get; set; }
	}
}
