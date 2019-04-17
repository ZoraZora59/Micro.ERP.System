using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IFundsData
    {
        void CreateVielationInfo(EmployeeViolationInfo employeeViolationInfo);
        void CreateSalaryInfo(FundsSalaryInfo fundsSalaryInfo);
        void CreateGoodsFundsRecord(FundsGoodsInfo fundsGoodsInfo);
        void CreateAssetsRecord(TotalAssetsInfo totalAssetsInfo);

        void UpdateVielationInfo(EmployeeViolationInfo employeeViolationInfo);
        void UpdateGoodsFundsRecord(FundsGoodsInfo fundsGoodsInfo);

        TotalAssetsInfo GetTotalAssetsNow();
        EmployeeViolationInfo GetEmployeeViolationInfo(int recordID);
        EmployeeSalary GetEmployeeSalaryBySalaryID(int salaryID);
        EmployeeSalary GetEmployeeSalaryByUserID(int userID);
        FundsGoodsInfo GetFundsGoodsInfo(int fundsGoodsInfo);

        List<TotalAssetsInfo> GetTotalAssetsInfos();
        List<EmployeeSalary> GetEmployeeSalaries();
        List<EmployeeViolationInfo> GetEmployeeViolationInfosByUserID(int userID);
        List<EmployeeViolationInfo> GetEmployeeViolationInfosByDate(int year, int month);
        List<EmployeeViolationInfo> GetEmployeeViolationInfos();
        List<FundsSalaryInfo> GetFundsSalaryInfos();
        List<FundsGoodsInfo> GetFundsGoodsInfos();
    }
}
