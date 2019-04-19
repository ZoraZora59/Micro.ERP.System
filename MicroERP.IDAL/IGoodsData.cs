using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IGoodsData
    {
        void CreateOrder(InfoGoodsOrder goodsOrderInfo);//创建新订单
        void CreateConfirm(InfoGoodsConfirm goodsConfirmInfo);//创建确认单
        void CreateReject(InfoGoodsRejectedOrder goodsRejectedOrderInfo);//创建驳回单
        void CreateGoodsResource(InfoGoodsResource goodsResourceInfo);//创建货存信息

        void UpdateOrder(InfoGoodsOrder goodsOrderInfo);//修改订单信息
        void UpdateConfirm(InfoGoodsConfirm goodsConfirmInfo);//更新确认单状态
        void UpdateRejact(InfoGoodsRejectedOrder goodsRejectedOrderInfo);//更新驳回单状态
        void UpdateGoodsResource(InfoGoodsResource goodsResourceInfo);//更新货存信息

        ViewGoodsApplyOrder GetGoodsApplyOrder(int OrderID);//获取申请的订单信息
        ViewGoodsConfirm GetGoodsConfirm(int ConfirmID);//获取确认单详情
        InfoGoodsOrder GetGoodsOrderInfo(int OrderID);//获取订单详情
        InfoGoodsResource GetGoodsResourceInfo(int GoodsID);//获取单项库存详情
        InfoGoodsRejectedOrder GetGoodsRejectedOrderInfo(int RejectID);//获取驳回单详情

        List<InfoGoodsResource> GetGoodsResourceInfos();//获取货物库存清单
        List<InfoGoodsRejectedOrder> GetGoodsRejectedOrderInfos();//获取驳回清单
        List<InfoGoodsConfirm> GetGoodsConfirmInfos();//获取确认清单
        List<ViewGoodsApplyOrder> GetGoodsApplyOrders();//获取申请清单
        List<InfoGoodsOrder> GetGoodsOrderInfos();//获取订单详情清单
    }
}
