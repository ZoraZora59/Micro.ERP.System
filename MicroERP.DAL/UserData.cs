using MicroERP.IDAL;
using MicroERP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroERP.DAL
{
    public class UserData : IUserData
    {
        //void IUserData.CreateEmployee(UserSelfInfo userSelf)
        //{
        //    using (MicroERPContext db = new MicroERPContext())
        //    {
        //        var self= db.UserSelfInfo.Add(userSelf);
        //        db.SaveChanges();
        //    }
        //}

        //public List<MicroERP.Model.UserLogin> GetList()
        //{
        //    using (MicroERPContext db = new MicroERPContext())
        //    {
        //        return db.UserLogin.ToList();
        //    }
        //}
        void IUserData.CreateEmployee(InfoUserSelf userSelf)
        {
            throw new NotImplementedException();
        }

        void IUserData.CreateUpdateRecord(InfoUserUpdate userUpdate)
        {
            throw new NotImplementedException();
        }

        List<ViewEmployee> IUserData.GetEmployeeViews()
        {
            throw new NotImplementedException();
        }

        ViewEmployee IUserData.GetUserEmploy(int userID)
        {
            throw new NotImplementedException();
        }

        ViewUserLogin IUserData.GetUserLogin(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Where(c => c.UserID == userID).Select(c => new ViewUserLogin() { UserID = c.UserID, UserPassword = c.UserPassword }).ToList().First();
            }
        }

        List<ViewUserLogin> IUserData.GetUserLogins()
        {
            throw new NotImplementedException();
        }

        ViewUserSelf IUserData.GetUserSelf(int userID)
        {
            throw new NotImplementedException();
        }

        List<InfoUserSelf> IUserData.GetUserSelfInfos()
        {
            throw new NotImplementedException();
        }

        List<ViewUserSelf> IUserData.GetUserSelves()
        {
            throw new NotImplementedException();
        }

        List<InfoUserUpdate> IUserData.GetUserUpdateInfos()
        {
            throw new NotImplementedException();
        }

        void IUserData.UpdateDetail(InfoUserSelf userSelf)
        {
            throw new NotImplementedException();
        }

        void IUserData.UpdateEmployee(InfoUserSelf userSelf)
        {
            throw new NotImplementedException();
        }
    }

}
