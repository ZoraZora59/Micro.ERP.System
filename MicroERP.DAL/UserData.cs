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
    public class UserData : IERPDAL
    {
        void IERPDAL.CreateNew(UserSelfInfo userSelf)
        {
            using (MicroERPEntities db = new MicroERPEntities())
            {
                var self= db.UserSelfInfo.Add(userSelf);
                db.SaveChanges();
                initNewUserLoginInfo(self.UserID,db);
            }
        }
        private void initNewUserLoginInfo(int uid , MicroERPEntities db)
        {
            db.UserLoginInfo.Add(new UserLoginInfo
            {
                UserID =uid,
                UserPassword="000000"
            });
            db.SaveChanges();
        }
    }
}
