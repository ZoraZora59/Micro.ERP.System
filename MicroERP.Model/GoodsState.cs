using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class GoodsState
	{
		[Display(Name = "货单编号")]
		public int GoodsID { get; set; }
		[Display(Name = "货单流向")]
		public string Target { get; set; }
		[Display(Name = "单价")]
		public int UnitPrice { get; set; }
		[Display(Name = "货物量")]
		public int AmountOfCargo { get; set; }
		[Display(Name = "下单人编号")]
		public int ApplicantID { get; set; }
		[Display(Name = "下单时间")]
		public DateTime ApplyTime { get; set; }
		[Display(Name = "下单备注")]
		public string ApplyNote { get; set; }
		[Display(Name = "审核人编号")]
		public int ConfirmorID { get; set; }
		[Display(Name = "审核时间")]
		public DateTime ConfirmeTime { get; set; }
		[Display(Name = "审核备注")]
		public string ConfirmNote { get; set; }

		public virtual ICollection<FundState> FundState { get; set; }
		public virtual PersonnelStatus ApplyOne{ get; set; }
		public virtual PersonnelStatus ConfirmOne { get; set; }
	}
}
