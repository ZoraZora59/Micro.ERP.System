using MicroERP.Model;
using System.Data.Entity;

namespace MicroERP.DAL
{
    #region 数据库上下文组件
    //[DbConfigurationType(typeof(System.Data.Entity.SqlServer.SqlProviderServices))]//添加与MSSQL类型相关的组件(默认)
    public class MicroERPContext : DbContext
    {
        public MicroERPContext() : base("name=MicroERPContext")
        { }
        public DbSet<InfoUserSelf> UserSelves { get; set; }
        public DbSet<InfoUserUpdate> UserUpdates { get; set; }
        //public DbSet<InfoGoodsResource> GoodsResources { get; set; }
        //public DbSet<InfoGoodsOrder> GoodsOrders { get; set; }
        //public DbSet<InfoGoodsConfirm> GoodsConfirms { get; set; }
        //public DbSet<InfoGoodsRejectedOrder> GoodsRejectedOrders { get; set; }
        //public DbSet<InfoTotalAssets> TotalAssets { get; set; }
        //public DbSet<InfoEmployeeViolation> EmployeeViolations { get; set; }
        //public DbSet<InfoFundsSalary> FundsSalaries { get; set; }
        //public DbSet<InfoFundsGoods> FundsGoods { get; set; }
    }
    #endregion
}
