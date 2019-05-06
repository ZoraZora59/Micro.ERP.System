using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.IDAL
{
    /// <summary>
    /// 员工数据访问类
    /// </summary>
    public interface IUserData
    {
        /// <summary>
        /// 创建新员工
        /// </summary>
        /// <param name="userSelf">个人信息实体</param>
        void CreateEmployee(InfoUserSelf userSelf);
        /// <summary>
        /// 创建资料更新记录
        /// </summary>
        /// <param name="userUpdate">更新记录实体</param>
        void CreateUpdateRecord(InfoUserUpdate userUpdate);

        /// <summary>
        /// 更新用户资料
        /// </summary>
        /// <param name="userSelf">完整的员工资料实体</param>
        void UpdateDetail(InfoUserSelf userSelf);

        /// <summary>
        /// 获取全部员工的员工资料信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        List<ViewUserAsEmployee> GetUserAsEmployee();

        /// <summary>
        /// 获取员工登录信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserLogin GetUserLogin(int userID);
        /// <summary>
        /// 获取员工个人资料中可以自由修改的部分
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserSelf GetUserSelf(int userID);
        /// <summary>
        /// 以员工资料的模型来获取员工信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserAsEmployee GetUserAsEmployee(int userID);

        /// <summary>
        /// 获取所有员工的全部信息
        /// </summary>
        /// <returns></returns>
        List<InfoUserSelf> GetUserSelfInfos();
        /// <summary>
        /// 获取所有员工信息中可以自由修改的部分
        /// </summary>
        /// <returns></returns>
        List<ViewUserSelf> GetUserSelves();
        /// <summary>
        /// 获取所有员工的资料更新记录
        /// </summary>
        /// <returns></returns>
        List<InfoUserUpdate> GetUserUpdateInfos();
        /// <summary>
        /// 获取单个用户的资料更新记录
        /// </summary>
        /// <returns></returns>
        List<InfoUserUpdate> GetThisUserUpdateInfos(int userID);
    }
}
