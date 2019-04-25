using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IFundsData
    {
        void CreateVielationInfo(InfoEmployeeViolation employeeViolationInfo);//增加员工违规记录
        void CreateSalaryInfo(InfoFundsSalary fundsSalaryInfo);//增加工资单记录
        void CreateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo);//新增货流资金记录
        void CreateAssetsRecord(InfoTotalAssets totalAssetsInfo);//新增总资产记录

        void UpdateVielationInfo(InfoEmployeeViolation employeeViolationInfo);//修改违规记录
        void UpdateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo);//修改货流资金记录

        InfoTotalAssets GetTotalAssetsNow();//获取最新总资产记录
        InfoEmployeeViolation GetEmployeeViolationInfo(int recordID);//按记录号获取员工违规记录
        //ViewEmployeeSalary GetEmployeeSalaryBySalaryID(int salaryID);//按工资单号获取工资单详情
        //ViewEmployeeSalary GetEmployeeSalaryByUserID(int userID);//按员工号获取最新工资单
        InfoFundsGoods GetFundsGoodsInfo(int fundsGoodsInfoID);//按资金编号获取资金单信息

        List<InfoTotalAssets> GetTotalAssetsInfos();//获取总资产变化清单
        //List<ViewEmployeeSalary> GetEmployeeSalaries();//获取所有员工工资表
        List<InfoEmployeeViolation> GetEmployeeViolationInfosByUserID(int userID);//按员工编号获取员工的违规记录
        List<InfoEmployeeViolation> GetEmployeeViolationInfosByDate(int year, int month);//按时间获取所有员工的当月违规记录
        List<InfoEmployeeViolation> GetEmployeeViolationInfos();//获取违规记录总清单
        List<InfoFundsSalary> GetFundsSalaryInfos();//获取工资单清单
        List<InfoFundsGoods> GetFundsGoodsInfos();//获取货流资金清单
    }
}
