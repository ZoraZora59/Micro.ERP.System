﻿using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    public interface IUserData
    {
        void CreateEmployee(UserSelfInfo userSelf);//新增职员
        void CreateUpdateRecord(UserUpdateInfo userUpdate);//添加人力资源更新记录

        void UpdateEmployee(UserSelfInfo userSelf);//更新职员资料
        void UpdateDetail(UserSelfInfo userSelf);//更新个人信息

        UserSelf GetUserSelf(int userID);//获取个人资料
        EmployeeView GetUserEmploy(int userID);//获取职位信息

        List<UserSelfInfo> GetUserSelfInfos();//获取全部个人资料表
        List<UserSelf> GetUserSelves();//获取个人信息表
        List<UserLogin> GetUserLogins();//获取登录信息表
        List<UserUpdateInfo> GetUserUpdateInfos();//获取职位变动记录表
        List<EmployeeView> GetEmployeeViews();//获取员工职位表
    }
}