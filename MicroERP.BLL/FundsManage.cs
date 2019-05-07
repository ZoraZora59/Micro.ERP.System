using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.Model;
using System;
using System.Collections.Generic;
namespace MicroERP.BLL
{
    /// <summary>
    /// 资金业务逻辑处理类
    /// </summary>
    public class FundsManage
    {
        private IFundsData fundsData;
        public FundsManage(FundsData data)
        {
            this.fundsData = data;
        }
    }
}
