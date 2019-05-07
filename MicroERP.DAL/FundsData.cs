using MicroERP.IDAL;
using MicroERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MicroERP.DAL
{
    /// <summary>
    /// 资金数据访问类
    /// </summary>
    public class FundsData : IFundsData
    {
        private readonly MicroERPContext db;
        public FundsData()
        {
            db = new MicroERPContext();
        }
        ~FundsData()
        {
            db.Dispose();
        }
        void IFundsData.CreateAssetsRecord(InfoTotalAssets totalAssetsInfo)
        {
            db.TotalAssets.Add(totalAssetsInfo);
            db.SaveChanges();
        }

        void IFundsData.CreateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo)
        {
            db.FundsGoods.Add(fundsGoodsInfo);
            db.SaveChanges();
        }

        void IFundsData.CreateSalaryRecord(InfoFundsSalary fundsSalaryInfo)
        {
            db.FundsSalaries.Add(fundsSalaryInfo);
            db.SaveChanges();
        }

        void IFundsData.CreateViolationRecord(InfoEmployeeViolation employeeViolationInfo)
        {
            db.EmployeeViolations.Add(employeeViolationInfo);
            db.SaveChanges();
        }

        List<InfoEmployeeViolation> IFundsData.GetAllEmployeeViolation()
        {
            return db.EmployeeViolations.ToList();
        }

        List<InfoFundsGoods> IFundsData.GetAllFundsGoods()
        {
            return db.FundsGoods.ToList();
        }

        List<InfoFundsSalary> IFundsData.GetAllFundsSalary()
        {
            return db.FundsSalaries.ToList();
        }

        List<InfoEmployeeViolation> IFundsData.GetEmployeeViolationInfosByDate(int year, int month)
        {
            //TODO:很可能会报错，需要检查
            return db.EmployeeViolations.Where(c => c.RecordDate.Year == year&&c.RecordDate.Month==month).ToList(); 
        }

        List<InfoEmployeeViolation> IFundsData.GetEmployeeViolationInfosByUserID(int userID)
        {
            return db.EmployeeViolations.Where(c => c.UserID == userID).ToList();
        }

        InfoFundsGoods IFundsData.GetFundsGoodsByRecordID(int fundsGoodsInfoID)
        {
            return db.FundsGoods.Find(fundsGoodsInfoID);
        }

        List<InfoTotalAssets> IFundsData.GetTotalAssetsInfos()
        {
            return db.TotalAssets.ToList();
        }

        InfoTotalAssets IFundsData.GetTotalAssetsNow()
        {
            //TODO:需要确定是First还是Last
            return db.TotalAssets.First();
            //return db.TotalAssets.Last();
        }

        InfoEmployeeViolation IFundsData.GetViolationByRecordID(int recordID)
        {
            return db.EmployeeViolations.Find(recordID);
        }

        void IFundsData.UpdateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo)
        {
            var before = db.FundsGoods.Find(fundsGoodsInfo.FundsForGoodsID);
            before.FundsNote = fundsGoodsInfo.FundsNote;
            before.FundsState = fundsGoodsInfo.FundsState;
            before.FundsUpdate = fundsGoodsInfo.FundsUpdate;
            before.GoodsOrderID = fundsGoodsInfo.GoodsOrderID;
            before.ConfirmDate = fundsGoodsInfo.ConfirmDate;
            before.CheckUserID = fundsGoodsInfo.CheckUserID;
            before.ConfirmID = fundsGoodsInfo.ConfirmID;
            db.SaveChanges();
        }

        void IFundsData.UpdateVielationRecord(InfoEmployeeViolation employeeViolationInfo)
        {
            var before = db.EmployeeViolations.Find(employeeViolationInfo.RecordID);
            before.RecordDate = employeeViolationInfo.RecordDate;
            before.ViolateFor = employeeViolationInfo.ViolateFor;
            before.FundsPunish = employeeViolationInfo.FundsPunish;
            before.UserID = employeeViolationInfo.UserID;
            db.SaveChanges();
        }
    }
}
