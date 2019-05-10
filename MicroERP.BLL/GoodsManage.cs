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
        private readonly IGoodsData goodsData;
        public GoodsManage()
        {
            goodsData = new GoodsData();
        }
        /// <summary>
        /// 获取货单总记录表
        /// </summary>
        /// <returns></returns>
        public List<GoodsListModel> GetOrderList()
        {
            var data = new List<GoodsListModel>();
            var sourceData = goodsData.GetAllGoodsOrder();
            IUserData uData = new UserData();
            foreach(var item in sourceData)
            {
                var addOne = new GoodsListModel
                {
                    ApplyUserID = item.ApplyUserID,
                    ApplyUserName = uData.GetUserSelf(item.ApplyUserID).UserName,
                    ConfirmID = item.ConfirmID == 0 ? "未审核" : item.ConfirmID.ToString(),
                    FundsID = item.FundsID == 0 ? "未发放" : item.FundsID.ToString(),
                    GoodsQuantity = item.GoodsQuantity,
                    GoodsResourceID = item.GoodsResourceID,
                    GoodsResourceName = goodsData.GetGoodsResource(item.GoodsResourceID).GoodsName,
                    GoodsTarget = item.GoodsTarget,
                    GoodsUnitPrice = item.GoodsUnitPrice,
                    OrderID = item.OrderID,
                    OrderTime = item.OrderTime.ToShortDateString(),
                    OrderType = item.OrderType,
                    RejectedOrderID = item.RejectedOrderID == 0 ? "无" : item.RejectedOrderID.ToString(),
                    SaleNote = item.SaleNote
                };
                data.Add(addOne);
            }
            return data;
        }
        public List<string> GetOrderType()
        {
            return TypesOfGoodsModel.orderType;
        }
    }
}
