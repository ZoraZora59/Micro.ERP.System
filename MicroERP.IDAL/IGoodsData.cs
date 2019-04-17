using MicroERP.Model;

namespace MicroERP.IDAL
{
    public interface IGoodsData
    {
        void CreateOrder(GoodsOrderInfo goodsOrderInfo);
        void CreateConfirm(GoodsConfirmInfo goodsConfirmInfo);
        void CreateReject(GoodsRejectedOrderInfo goodsRejectedOrderInfo);
        void CreateGoodsResource(GoodsResourceInfo goodsResourceInfo);

        void UpdateOrder(GoodsOrderInfo goodsOrderInfo);
        void UpdateConfirm(GoodsConfirmInfo goodsConfirmInfo);
        void UpdateRejact(GoodsRejectedOrderInfo goodsRejectedOrderInfo);
        void UpdateGoodsResource(GoodsResourceInfo goodsResourceInfo);

        GoodsApplyOrder GetGoodsApplyOrder(int OrderID);
        GoodsConfirm GetGoodsConfirm(int ConfirmID);
        GoodsResourceInfo GetGoodsResourceInfo(int GoodsID);
        GoodsRejectedOrderInfo GetGoodsRejectedOrderInfo(int RejectID);
    }
}
