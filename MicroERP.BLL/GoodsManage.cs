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
    /// 货物业务逻辑处理类
    /// </summary>
    public class GoodsManage
    {
        private IGoodsData goodsData;
        public GoodsManage(GoodsData data)
        {
            this.goodsData = data;
        }
    }
}
