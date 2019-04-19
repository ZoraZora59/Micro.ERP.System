using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IFundsData
    {
        void CreateVielationInfo(EmployeeViolationInfo employeeViolationInfo);//增加员工违规记录
        void CreateSalaryInfo(FundsSalaryInfo fundsSalaryInfo);//增加工资单记录
        void CreateGoodsFundsRecord(FundsGoodsInfo fundsGoodsInfo);//新增货流资金记录
        void CreateAssetsRecord(TotalAssetsInfo totalAssetsInfo);//新增总资产记录

        void UpdateVielationInfo(EmployeeViolationInfo employeeViolationInfo);//修改违规记录
        void UpdateGoodsFundsRecord(FundsGoodsInfo fundsGoodsInfo);//修改货流资金记录

        TotalAssetsInfo GetTotalAssetsNow();//获取最新总资产记录
        EmployeeViolationInfo GetEmployeeViolationInfo(int recordID);//按记录号获取员工违规记录
        ViewEmployeeSalary GetEmployeeSalaryBySalaryID(int salaryID);//按工资单号获取工资单详情
        ViewEmployeeSalary GetEmployeeSalaryByUserID(int userID);//按员工号获取最新工资单
        FundsGoodsInfo GetFundsGoodsInfo(int fundsGoodsInfoID);//按资金编号获取资金单信息

        List<TotalAssetsInfo> GetTotalAssetsInfos();//获取总资产变化清单
        List<ViewEmployeeSalary> GetEmployeeSalaries();//获取所有员工工资表
        List<EmployeeViolationInfo> GetEmployeeViolationInfosByUserID(int userID);//按员工编号获取员工的违规记录
        List<EmployeeViolationInfo> GetEmployeeViolationInfosByDate(int year, int month);//按时间获取所有员工的当月违规记录
        List<EmployeeViolationInfo> GetEmployeeViolationInfos();//获取违规记录总清单
        List<FundsSalaryInfo> GetFundsSalaryInfos();//获取工资单清单
        List<FundsGoodsInfo> GetFundsGoodsInfos();//获取货流资金清单
    }
}
