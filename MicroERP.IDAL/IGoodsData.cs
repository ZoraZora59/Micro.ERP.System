using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    /// <summary>
    /// 货物数据访问接口类
    /// </summary>
    public interface IGoodsData
    {
        /// <summary>
        /// 创建新订单
        /// </summary>
        /// <param name="goodsOrderInfo"></param>
        void CreateOrder(InfoGoodsOrder goodsOrderInfo);

        /// <summary>
        /// 创建确认单
        /// </summary>
        /// <param name="goodsConfirmInfo"></param>
        void CreateConfirm(InfoGoodsConfirm goodsConfirmInfo);

        /// <summary>
        /// 创建驳回单
        /// </summary>
        /// <param name="goodsRejectedOrderInfo"></param>
        void CreateReject(InfoGoodsRejectedOrder goodsRejectedOrderInfo);

        /// <summary>
        /// 创建货存信息
        /// </summary>
        /// <param name="goodsResourceInfo"></param>
        void CreateGoodsResource(InfoGoodsResource goodsResourceInfo);


        /// <summary>
        /// 修改订单信息
        /// </summary>
        /// <param name="goodsOrderInfo"></param>
        void UpdateOrder(InfoGoodsOrder goodsOrderInfo);

        /// <summary>
        /// 更新确认单状态
        /// </summary>
        /// <param name="goodsConfirmInfo"></param>
        void UpdateConfirm(InfoGoodsConfirm goodsConfirmInfo);

        /// <summary>
        /// 更新驳回单状态
        /// </summary>
        /// <param name="goodsRejectedOrderInfo"></param>
        void UpdateRejact(InfoGoodsRejectedOrder goodsRejectedOrderInfo);

        /// <summary>
        /// 更新货存信息
        /// </summary>
        /// <param name="goodsResourceInfo"></param>
        void UpdateGoodsResource(InfoGoodsResource goodsResourceInfo);


        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        InfoGoodsOrder GetGoodsOrder(int OrderID);

        /// <summary>
        /// 获取单项库存详情
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns></returns>
        InfoGoodsResource GetGoodsResource(int GoodsID);

        /// <summary>
        /// 获取驳回单详情
        /// </summary>
        /// <param name="RejectID"></param>
        /// <returns></returns>
        InfoGoodsRejectedOrder GetGoodsRejected(int RejectID);


        /// <summary>
        /// 获取货物库存清单
        /// </summary>
        /// <returns></returns>
        List<InfoGoodsResource> GetAllGoodsResource();

        /// <summary>
        /// 获取全部驳回单的列表
        /// </summary>
        /// <returns></returns>
        List<InfoGoodsRejectedOrder> GetAllGoodsRejectedOrder();

        /// <summary>
        /// 获取全部确认单列表
        /// </summary>
        /// <returns></returns>
        List<InfoGoodsConfirm> GetAllGoodsConfirm();

        /// <summary>
        /// 获取全部订单详情
        /// </summary>
        /// <returns></returns>
        List<InfoGoodsOrder> GetAllGoodsOrder();
    }
}
