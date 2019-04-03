using System;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class FundState
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
		[Display(Name = "申请时间")]
		public DateTime ApplyTime { get; set; }
		[Display(Name = "生效时间")]
		public DateTime PayTime { get; set; }

		[Display(Name = "对应货单")]
		public virtual GoodsState Goods { get; set; }
		public virtual PersonnelStatus ApplyOne { get; set; }
		public virtual PersonnelStatus ConfirmOne { get; set; }
	}
}