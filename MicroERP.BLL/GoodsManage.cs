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
            foreach (var item in sourceData)
            {
                var addOne = new GoodsListModel();
                addOne.ApplyUserID = item.ApplyUserID;
                addOne.ApplyUserName = uData.GetUserSelf(item.ApplyUserID).UserName;
                addOne.ConfirmID = item.ConfirmID == 0 ? "未审核" : item.ConfirmID.ToString();
                addOne.FundsID = item.FundsID == 0 ? "未发放" : item.FundsID.ToString();
                addOne.GoodsQuantity = item.GoodsQuantity;
                addOne.GoodsResourceID = item.GoodsResourceID;
                if(addOne.GoodsResourceID!=0)
                    addOne.GoodsResourceName = goodsData.GetGoodsResource(item.GoodsResourceID).GoodsName;
                addOne.GoodsTarget = item.GoodsTarget;
                addOne.GoodsUnitPrice = item.GoodsUnitPrice;
                addOne.OrderID = item.OrderID;
                addOne.OrderTime = item.OrderTime.ToShortDateString();
                addOne.OrderType = item.OrderType;
                addOne.RejectedOrderID = item.RejectedOrderID == 0 ? "无" : item.RejectedOrderID.ToString();
                addOne.SaleNote = item.SaleNote;
                data.Add(addOne);
            }
            return data;
        }
        /// <summary>
        /// 获取静态货单类型表
        /// </summary>
        /// <returns></returns>
        public List<string> GetOrderTypeList()
        {
            return TypesOfGoodsModel.orderType;
        }
        /// <summary>
        /// 创建新订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool CreateOrder(InfoGoodsOrder order)
        {
            bool isSuccess = false;
            goodsData.CreateOrder(order);
            isSuccess = true;
            return isSuccess;
        }
    }
}
