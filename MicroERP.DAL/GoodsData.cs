using MicroERP.IDAL;
using MicroERP.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroERP.DAL
{
    /// <summary>
    /// 货物数据访问类
    /// </summary>
    public class GoodsData : IGoodsData
    {
        private readonly MicroERPContext db;
        public GoodsData()
        {
            db = new MicroERPContext();
        }
        ~GoodsData()
        {
            db.Dispose();
        }
        void IGoodsData.CreateConfirm(InfoGoodsConfirm goodsConfirmInfo)
        {
            db.GoodsConfirms.Add(goodsConfirmInfo);
            db.SaveChanges();
        }

        void IGoodsData.CreateGoodsResource(InfoGoodsResource goodsResourceInfo)
        {
            db.GoodsResources.Add(goodsResourceInfo);
            db.SaveChanges();
        }

        void IGoodsData.CreateOrder(InfoGoodsOrder goodsOrderInfo)
        {
            db.GoodsOrders.Add(goodsOrderInfo);
            db.SaveChanges();
        }

        void IGoodsData.CreateReject(InfoGoodsRejectedOrder goodsRejectedOrderInfo)
        {
            db.GoodsRejectedOrders.Add(goodsRejectedOrderInfo);
            db.SaveChanges();
        }

        List<InfoGoodsConfirm> IGoodsData.GetAllGoodsConfirm()
        {
            return db.GoodsConfirms.ToList();
        }

        List<InfoGoodsOrder> IGoodsData.GetAllGoodsOrder()
        {
            return db.GoodsOrders.ToList();
        }

        List<InfoGoodsRejectedOrder> IGoodsData.GetAllGoodsRejectedOrder()
        {
            return db.GoodsRejectedOrders.ToList();
        }

        List<InfoGoodsResource> IGoodsData.GetAllGoodsResource()
        {
            return db.GoodsResources.ToList();
        }

        InfoGoodsOrder IGoodsData.GetGoodsOrder(int OrderID)
        {
            return db.GoodsOrders.Find(OrderID);
        }

        InfoGoodsRejectedOrder IGoodsData.GetGoodsRejected(int RejectID)
        {
            return db.GoodsRejectedOrders.Find(RejectID);
        }

        InfoGoodsResource IGoodsData.GetGoodsResource(int GoodsID)
        {
            return db.GoodsResources.Find(GoodsID);
        }

        void IGoodsData.UpdateConfirm(InfoGoodsConfirm goodsConfirmInfo)
        {
            var before = db.GoodsConfirms.Find(goodsConfirmInfo.ConfirmID);
            before.ConfirmNote = goodsConfirmInfo.ConfirmNote;
            before.ConfirmType = goodsConfirmInfo.ConfirmType;
            before.ConfirmDate = goodsConfirmInfo.ConfirmDate;
            before.ConfirmerID = goodsConfirmInfo.ConfirmerID;
            db.SaveChanges();
        }

        void IGoodsData.UpdateGoodsResource(InfoGoodsResource goodsResourceInfo)
        {
            var before = db.GoodsResources.Find(goodsResourceInfo.GoodsID);
            before.GoodsQuantity = goodsResourceInfo.GoodsQuantity;
            db.SaveChanges();
        }

        void IGoodsData.UpdateOrder(InfoGoodsOrder goodsOrderInfo)
        {
            var before = db.GoodsOrders.Find(goodsOrderInfo.OrderID);
            before.FundsID = goodsOrderInfo.FundsID;
            before.GoodsQuantity = goodsOrderInfo.GoodsQuantity;
            before.GoodsTarget = goodsOrderInfo.GoodsTarget;
            before.GoodsUnitPrice = goodsOrderInfo.GoodsUnitPrice;
            before.OrderTime = goodsOrderInfo.OrderTime;
            before.SaleNote = goodsOrderInfo.SaleNote;
            before.RejectedOrderID = goodsOrderInfo.RejectedOrderID;
            before.GoodsResourceID = goodsOrderInfo.GoodsResourceID;
            before.ConfirmID = goodsOrderInfo.ConfirmID;
            before.ApplyUserID = goodsOrderInfo.ApplyUserID;
            db.SaveChanges();
        }

        void IGoodsData.UpdateRejact(InfoGoodsRejectedOrder goodsRejectedOrderInfo)
        {
            var before = db.GoodsRejectedOrders.Find(goodsRejectedOrderInfo.RejectID);
            before.RejectDate = goodsRejectedOrderInfo.RejectDate;
            before.RejectNote = goodsRejectedOrderInfo.RejectNote;
            before.RejectState = goodsRejectedOrderInfo.RejectState;
            before.CheckUserID = goodsRejectedOrderInfo.CheckUserID;
            before.ConfirmID = goodsRejectedOrderInfo.ConfirmID;
            before.GoodsOrderID = goodsRejectedOrderInfo.GoodsOrderID;
            db.SaveChanges();
        }
    }
}
