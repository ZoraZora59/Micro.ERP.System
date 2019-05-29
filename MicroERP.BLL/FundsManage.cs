using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.Model;
using System;
using System.Collections.Generic;
namespace MicroERP.BLL
{
    /// <summary>
    /// 资金业务逻辑处理类
    /// </summary>
    public class FundsManage
    {
        private readonly IFundsData fundsData;
        public FundsManage()
        {
            this.fundsData = new FundsData();
        }
        /// <summary>
        /// 获取全部货流资金表
        /// </summary>
        /// <returns></returns>
        public List<InfoFundsGoods> GetFundsOfGoodsList()
        {
            return fundsData.GetAllFundsGoods();
        }
        public bool UpdateFundsCheck(int fundsID,string checkType,int checkUserID)
        {
            bool isSuccess = false;
            return isSuccess;
        }
        /// <summary>
        /// 创建货流资金记录
        /// </summary>
        /// <param name="fundsGoods"></param>
        /// <returns></returns>
        public bool CreateFundsOfGoods(InfoFundsGoods fundsGoods)
        {
            bool isSuccess = false;
            fundsData.CreateGoodsFundsRecord(fundsGoods);
            return isSuccess;
        }
        /// <summary>
        /// 为所有在职员工发放当月工资
        /// </summary>
        /// <returns></returns>
        public bool PaySalary()
        {
            bool isSuccess = false;
            IUserData userData = new UserData();
            var user = userData.GetUserAsEmployee().FindAll(c=>c.UserStatus=="在职");
            foreach(var one in user)
            {
                decimal bonus = 0;
                var temp = userData.GetEmployeeViolations().FindAll(c => c.ReferID == one.UserID && c.RecordDate.Month == DateTime.Now.Month);
                if(temp!=null)
                {
                    foreach (var every in temp)
                    {
                        bonus += every.FundsPunish;
                    }
                }
                fundsData.CreateSalaryRecord(new InfoFundsSalary { BaseSalary = one.UserSalary, UserID = one.UserID, PayWagesDate = DateTime.Now, PerformanceBonus = bonus, RealWage = one.UserSalary - bonus });
            }
            return isSuccess;
        }
    }
}
