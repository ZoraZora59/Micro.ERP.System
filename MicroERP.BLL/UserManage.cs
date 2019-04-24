using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroERP.Model;
using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.BLL.Models;

namespace MicroERP.BLL
{
    public class UserManage
    {
        IUserData userData;
        public UserManage()
        {
            this.userData = new UserData();
        }
        public bool CreateNewEmployee(InfoUserSelf userSelfInfo)
        {
            bool IsSuccess = false;
            //IUserData userData = new UserData();
            //userData.CreateEmployee(userSelfInfo);
            return IsSuccess;
        }

        public ViewUserAsEmployee Login(UserLoginForm model)
        {
            var userLogin = userData.GetUserLogin(model.UserID);
            if (model.Password == userLogin.UserPassword)
                return userData.GetUserAsEmployee(model.UserID);
            return null;
        }
        //public List<UserLogin> GetList()
        //{
        //    var us = new UserData();
        //    return us.GetList();
        //}
    }
}
