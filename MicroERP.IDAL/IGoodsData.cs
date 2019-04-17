using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IGoodsData
    {
        void CreateOrder(GoodsOrderInfo goodsOrderInfo);//创建新订单
        void CreateConfirm(GoodsConfirmInfo goodsConfirmInfo);//创建确认单
        void CreateReject(GoodsRejectedOrderInfo goodsRejectedOrderInfo);//创建驳回单
        void CreateGoodsResource(GoodsResourceInfo goodsResourceInfo);//创建货存信息

        void UpdateOrder(GoodsOrderInfo goodsOrderInfo);//修改订单信息
        void UpdateConfirm(GoodsConfirmInfo goodsConfirmInfo);//更新确认单状态
        void UpdateRejact(GoodsRejectedOrderInfo goodsRejectedOrderInfo);//更新驳回单状态
        void UpdateGoodsResource(GoodsResourceInfo goodsResourceInfo);//更新货存信息

        GoodsApplyOrder GetGoodsApplyOrder(int OrderID);//获取申请的订单信息
        GoodsConfirm GetGoodsConfirm(int ConfirmID);//获取确认单详情
        GoodsOrderInfo GetGoodsOrderInfo(int OrderID);//获取订单详情
        GoodsResourceInfo GetGoodsResourceInfo(int GoodsID);//获取单项库存详情
        GoodsRejectedOrderInfo GetGoodsRejectedOrderInfo(int RejectID);//获取驳回单详情

        List<GoodsResourceInfo> GetGoodsResourceInfos();//获取货物库存清单
        List<GoodsRejectedOrderInfo> GetGoodsRejectedOrderInfos();//获取驳回清单
        List<GoodsConfirmInfo> GetGoodsConfirmInfos();//获取确认清单
        List<GoodsApplyOrder> GetGoodsApplyOrders();//获取申请清单
        List<GoodsOrderInfo> GetGoodsOrderInfos();//获取订单详情清单
    }
}
