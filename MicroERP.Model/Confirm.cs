using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class Confirm
	{
		[Display(Name = "审核人编号")]
		public int ConfirmorID { get; set; }
		[Display(Name = "审核时间")]
		public DateTime ConfirmeTime { get; set; }
		[MaxLength(400, ErrorMessage = "{0}最大长度{1}")]
		[Display(Name = "审核备注")]
		public string ConfirmNote { get; set; }

		public virtual FundState FundState { get; set; }
		public virtual GoodsState GoodsState { get; set; }
	}
}
