using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.Model;
using System;
using System.Collections.Generic;

namespace MicroERP.BLL
{
    public class UserManage
    {
        private readonly IUserData userData;
        public UserManage()
        {
            this.userData = new UserData();
        }
        /// <summary>
        /// 以员工的模型获取全部用户信息
        /// </summary>
        /// <returns></returns>
        public List<ViewUserAsEmployee> GetUserAsEmployees()
        {
            return userData.GetUserAsEmployee();
        }
        /// <summary>
        /// 创建新用户
        /// </summary>
        /// <param name="userSelfInfo">密码和在职状态会被覆盖</param>
        /// <returns></returns>
        public bool CreateNewEmployee(InfoUserSelf userSelfInfo)
        {
            bool IsSuccess = false;
            userSelfInfo.UserPassword = md5tool.GetMD5("123123");
            userSelfInfo.UserStatus = "在职";
            userData.CreateEmployee(userSelfInfo);
            IsSuccess = true;
            return IsSuccess;
        }
        /// <summary>
        /// 获取静态职位表
        /// </summary>
        /// <returns></returns>
        public List<string> GetPositionList()
        {
            return EmployeeResourceModel.position;
        }
        /// <summary>
        /// 获取静态部门表
        /// </summary>
        /// <returns></returns>
        public List<string> GetDepartmentList()
        {
            return EmployeeResourceModel.department;
        }
        /// <summary>
        /// 获取静态在职状态表
        /// </summary>
        /// <returns></returns>
        public List<string> GetStateList()
        {
            return EmployeeResourceModel.state;
        }
        /// <summary>
        /// 匹配单个用户登录信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns>匹配失败返回null，成功返回实体</returns>
        public ViewUserAsEmployee Login(UserLoginForm model)
        {
            var userLogin = userData.GetUserLogin(model.UserID);
            if (model.Password == userLogin.UserPassword)
                return userData.GetUserAsEmployee(model.UserID);
            return null;
        }
        /// <summary>
        /// 获取单个用户的人力资源信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public ViewUserAsEmployee GetThisUserAsEmployee(int UserID)
        {
            return userData.GetUserAsEmployee(UserID);
        }
        /// <summary>
        /// 更新员工的人力资源信息
        /// </summary>
        /// <param name="userAsEmployee"></param>
        /// <returns></returns>
        public bool UpdateUserAsEmployee(ViewUserAsEmployee userAsEmployee,int UpdateBy , string UpdateNote)
        {
            bool isSuccess = false;
            //构造实体
            InfoUserSelf userSelf = userData.GetUserSelfInfos(userAsEmployee.UserID);
            userSelf.UserPosition = userAsEmployee.UserPosition;
            userSelf.UserDepartment = userAsEmployee.UserDepartment;
            userSelf.UserSalary = userAsEmployee.UserSalary;
            userSelf.UserStatus = userAsEmployee.UserStatus;
            //登记更新记录
            InfoUserSelf beforeUpdate = userData.GetUserSelfInfos(userAsEmployee.UserID);
            if(beforeUpdate.UserPosition!=userSelf.UserPosition)
                CreateNewUpdateInfo("职位", userSelf.UserPosition, beforeUpdate.UserPosition, UpdateNote, userAsEmployee.UserID, UpdateBy);
            if (beforeUpdate.UserDepartment != userSelf.UserDepartment)
                CreateNewUpdateInfo("所属部门", userSelf.UserDepartment, beforeUpdate.UserDepartment, UpdateNote, userAsEmployee.UserID, UpdateBy);
            if (beforeUpdate.UserSalary != userSelf.UserSalary)
                CreateNewUpdateInfo("预期薪资", userSelf.UserSalary.ToString(), beforeUpdate.UserSalary.ToString(), UpdateNote, userAsEmployee.UserID, UpdateBy);
            if (beforeUpdate.UserStatus != userSelf.UserStatus)
                CreateNewUpdateInfo("在职状态", userSelf.UserStatus, beforeUpdate.UserStatus, UpdateNote, userAsEmployee.UserID, UpdateBy);
            //开始更新
            userData.UpdateDetail(userSelf);
            return isSuccess;
        }
        /// <summary>
        /// 创建更新记录
        /// </summary>
        /// <param name="_UpdateType"></param>
        /// <param name="_SetInto"></param>
        /// <param name="_SetFrom"></param>
        /// <param name="_UpdateNote"></param>
        /// <param name="_UserID"></param>
        /// <param name="_UpdateBy"></param>
        /// <returns></returns>
        public void CreateNewUpdateInfo(string _UpdateType,string _SetInto ,string _SetFrom,string _UpdateNote, int _UserID,int _UpdateBy)
        {
            userData.CreateUpdateRecord(new InfoUserUpdate
            {
                UpdateBy = _UpdateBy,
                UpdateType = _UpdateType,
                UpdateInformation = _UpdateNote,
                UpdateInto = _SetInto,
                UpdateTime = DateTime.Now,
                UpdateFrom = _SetFrom,
                UserID = _UserID
            });
        }
        public List<InfoUserUpdate> GetUpdatesByUserID(int userID)
        {
            return userData.GetThisUserUpdateInfos(userID);
        }
        public List<InfoUserUpdate> GetAllUpdate()
        {
            return userData.GetUserUpdateInfos();
        }
    }
}