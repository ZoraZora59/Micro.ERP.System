using MicroERP.IDAL;
using MicroERP.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroERP.DAL
{
    /// <summary>
    /// 资金数据访问类
    /// </summary>
    public class FundsData : IFundsData
    {
        private MicroERPContext db;
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
            throw new System.NotImplementedException();
        }

        void IFundsData.CreateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo)
        {
            throw new System.NotImplementedException();
        }

        void IFundsData.CreateSalaryRecord(InfoFundsSalary fundsSalaryInfo)
        {
            throw new System.NotImplementedException();
        }

        void IFundsData.CreateVielationRecord(InfoEmployeeViolation employeeViolationInfo)
        {
            throw new System.NotImplementedException();
        }

        List<InfoEmployeeViolation> IFundsData.GetAllEmployeeViolation()
        {
            throw new System.NotImplementedException();
        }

        List<InfoFundsGoods> IFundsData.GetAllFundsGoods()
        {
            throw new System.NotImplementedException();
        }

        List<InfoFundsSalary> IFundsData.GetAllFundsSalary()
        {
            throw new System.NotImplementedException();
        }

        List<InfoEmployeeViolation> IFundsData.GetEmployeeViolationInfosByDate(int year, int month)
        {
            throw new System.NotImplementedException();
        }

        List<InfoEmployeeViolation> IFundsData.GetEmployeeViolationInfosByUserID(int userID)
        {
            throw new System.NotImplementedException();
        }

        InfoFundsGoods IFundsData.GetFundsGoodsByRecordID(int fundsGoodsInfoID)
        {
            throw new System.NotImplementedException();
        }

        List<InfoTotalAssets> IFundsData.GetTotalAssetsInfos()
        {
            throw new System.NotImplementedException();
        }

        InfoTotalAssets IFundsData.GetTotalAssetsNow()
        {
            throw new System.NotImplementedException();
        }

        InfoEmployeeViolation IFundsData.GetViolationByRecordID(int recordID)
        {
            throw new System.NotImplementedException();
        }

        void IFundsData.UpdateGoodsFundsRecord(InfoFundsGoods fundsGoodsInfo)
        {
            throw new System.NotImplementedException();
        }

        void IFundsData.UpdateVielationRecord(InfoEmployeeViolation employeeViolationInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
