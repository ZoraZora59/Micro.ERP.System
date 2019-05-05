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

        public List<ViewUserAsEmployee> GetUserAsEmployees()
        {
            return userData.GetUserAsEmployee();
        }

        public bool CreateNewEmployee(InfoUserSelf userSelfInfo)
        {
            bool IsSuccess = false;
            userSelfInfo.UserStatus = "在职";
            userData.CreateEmployee(userSelfInfo);
            IsSuccess = true;
            return IsSuccess;
        }
        public List<string> GetPositionList()
        {
            return EmployeeResourceModel.Position;
        }
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
