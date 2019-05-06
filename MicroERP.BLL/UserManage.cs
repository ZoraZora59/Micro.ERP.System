using MicroERP.BLL.App_Code;
using MicroERP.BLL.Models;
using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.Model;
using System.Collections.Generic;

namespace MicroERP.BLL
{
    public class UserManage
    {
        IUserData userData;
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
            return EmployeeResourceModel.Position;
        }
        /// <summary>
        /// 获取静态部门表
        /// </summary>
        /// <returns></returns>
        public List<string> GetDepartmentList()
        {
            return EmployeeResourceModel.Department;
        }
        public ViewUserAsEmployee Login(UserLoginForm model)
        {
            var userLogin = userData.GetUserLogin(model.UserID);
            if (model.Password == userLogin.UserPassword)
                return userData.GetUserAsEmployee(model.UserID);
            return null;
        }
    }
}
