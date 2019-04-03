using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class Apply
	{
		[Display(Name = "下单人编号")]
		public int ApplicantID { get; set; }
		[Display(Name = "下单时间")]
		public DateTime ApplyTime { get; set; }
		[MaxLength(400, ErrorMessage = "{0}最大长度{1}")]
		[Display(Name = "下单备注")]
		public string ApplyNote { get; set; }
		
	}
}
