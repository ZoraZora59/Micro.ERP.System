using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroERP.Model;
using MicroERP.DAL;
using MicroERP.IDAL;

namespace MicroERP.BLL
{
    public class UserManage
    {
        public bool CreateNewEmployee(UserSelfInfo userSelfInfo)
        {
            bool IsSuccess = false;
            //IUserData userData = new UserData();
            //userData.CreateEmployee(userSelfInfo);
            return IsSuccess;
        }
        //public List<UserLogin> GetList()
        //{
        //    var us = new UserData();
        //    return us.GetList();
        //}
    }
}
