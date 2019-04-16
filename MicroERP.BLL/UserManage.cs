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
            IERPDAL userData = new UserData();
            userData.CreateNew(userSelfInfo);
            return IsSuccess;
        }
    }
}
