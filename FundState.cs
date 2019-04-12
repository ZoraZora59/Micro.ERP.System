using System;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class FundState//TODO:数据库设计问题
	{
		[Display(Name = "资金流编号")]
		public int FundID { get; set; }
		[Display(Name = "货单编号")]
		public int GoodsID { get; set; }
		[Display(Name = "申请人编号")]
		public int ApplicantID { get; set; }
		[Display(Name = "确认人编号")]
		public int ConfirmorID { get; set; }
		[Display(Name = "金额")]
		public int Amount { get; set; }

		public virtual Confirm ConfirmOne { get; set; }
		public virtual Apply ApplyOne { get; set; }
	}
}