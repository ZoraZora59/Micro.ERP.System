using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MicroERP.Model
{
	public class GoodsState
	{
		[Key]
		[Display(Name = "货单编号")]
		public int GoodsID { get; set; }
		[Required(ErrorMessage ="{0}必须填写")]
		[Display(Name = "货单流向")]
		public string Target { get; set; }
		[Required(ErrorMessage = "{0}必须填写")]
		[Display(Name = "单价")]
		public int UnitPrice { get; set; }
		[Required(ErrorMessage = "{0}必须填写")]
		[Display(Name = "货物量")]
		public int AmountOfCargo { get; set; }
		
		

		

		public virtual FundState FundState { get; set; }
		public virtual PersonnelStatus ApplyOne{ get; set; }
		public virtual PersonnelStatus ConfirmOne { get; set; }
	}
}
