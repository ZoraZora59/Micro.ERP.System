using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IFundsData
    {
        /// <summary>
        /// 增加员工违规记录
        /// </summary>
        /// <param name="employeeViolationInfo"></param>
        void CreateVielationRecord(InfoEmployeeViolation employeeViolationInfo);

        /// <summary>
        /// 增加工资单记录
        /// </summary>
        /// <param name="fundsSalaryInfo"></param>
        void CreateSalaryRecord(InfoFundsSalary fundsSalaryInfo);

        /// <summary>
        /// 新增货流资金记录
        /// </summary>
        /// <param name="fundsGoodsInfo"></param>
        void CreateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo);

        /// <summary>
        /// 新增总资产记录
        /// </summary>
        /// <param name="totalAssetsInfo"></param>
        void CreateAssetsRecord(InfoTotalAssets totalAssetsInfo);


        /// <summary>
        /// 修改违规记录
        /// </summary>
        /// <param name="employeeViolationInfo"></param>
        void UpdateVielationRecord(InfoEmployeeViolation employeeViolationInfo);

        /// <summary>
        /// 修改货流资金记录
        /// </summary>
        /// <param name="fundsGoodsInfo"></param>
        void UpdateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo);


        /// <summary>
        /// 获取最新总资产记录
        /// </summary>
        /// <returns></returns>
        InfoTotalAssets GetTotalAssetsNow();

        /// <summary>
        /// 按记录号获取员工违规记录
        /// </summary>
        /// <param name="recordID">记录号</param>
        /// <returns></returns>
        InfoEmployeeViolation GetViolationByRecordID(int recordID);

        /// <summary>
        /// 按资金编号获取资金单信息
        /// </summary>
        /// <param name="fundsGoodsInfoID">货流资金编号</param>
        /// <returns></returns>
        InfoFundsGoods GetFundsGoodsByRecordID(int fundsGoodsInfoID);


        /// <summary>
        /// 获取总资产变化清单
        /// </summary>
        /// <returns></returns>
        List<InfoTotalAssets> GetTotalAssetsInfos();

        /// <summary>
        /// 按员工编号获取员工的违规记录
        /// </summary>
        /// <param name="userID">员工ID</param>
        /// <returns></returns>
        List<InfoEmployeeViolation> GetEmployeeViolationInfosByUserID(int userID);

        /// <summary>
        /// 按时间获取所有员工的当月违规记录
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        List<InfoEmployeeViolation> GetEmployeeViolationInfosByDate(int year, int month);

        /// <summary>
        /// 获取违规记录总清单
        /// </summary>
        /// <returns></returns>
        List<InfoEmployeeViolation> GetAllEmployeeViolation();

        /// <summary>
        /// 获取工资单清单
        /// </summary>
        /// <returns></returns>
        List<InfoFundsSalary> GetAllFundsSalary();

        /// <summary>
        /// 获取货流资金清单
        /// </summary>
        /// <returns></returns>
        List<InfoFundsGoods> GetAllFundsGoods();
    }
}
