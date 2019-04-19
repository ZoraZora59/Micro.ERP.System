using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IUserData
    {
        void CreateEmployee(InfoUserSelf userSelf);//新增职员
        void CreateUpdateRecord(InfoUserUpdate userUpdate);//添加人力资源更新记录

        void UpdateEmployee(InfoUserSelf userSelf);//更新职员资料
        void UpdateDetail(InfoUserSelf userSelf);//更新个人信息

        ViewUserSelf GetUserSelf(int userID);//获取个人资料
        ViewEmployee GetUserEmploy(int userID);//获取职位信息

        List<InfoUserSelf> GetUserSelfInfos();//获取全部个人资料表
        List<ViewUserSelf> GetUserSelves();//获取个人信息表
        List<ViewUserLogin> GetUserLogins();//获取登录信息表
        List<InfoUserUpdate> GetUserUpdateInfos();//获取职位变动记录表
        List<ViewEmployee> GetEmployeeViews();//获取员工职位表
    }
}
