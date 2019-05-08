using MicroERP.IDAL;
using MicroERP.Model;
using System.Collections.Generic;
using System.Linq;

namespace MicroERP.DAL
{
    /// <summary>
    /// 员工数据访问类
    /// </summary>
    public class UserData : IUserData
    {
        /// <summary>
        /// 创建新员工
        /// </summary>
        /// <param name="userSelf">个人信息实体</param>
        void IUserData.CreateEmployee(InfoUserSelf userSelf)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                db.UserSelves.Add(userSelf);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 创建资料更新记录
        /// </summary>
        /// <param name="userUpdate">更新记录实体</param>
        void IUserData.CreateUpdateRecord(InfoUserUpdate userUpdate)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                db.UserUpdates.Add(userUpdate);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 获取单个用户的资料更新记录
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        List<InfoUserUpdate> IUserData.GetThisUserUpdateInfos(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserUpdates.Where(c => c.UserID == userID).ToList();
            }
        }

        /// <summary>
        /// 以员工资料的模型来获取员工信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserAsEmployee IUserData.GetUserAsEmployee(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Where(c => c.UserID == userID).Select(c => new ViewUserAsEmployee()
                {
                    UserID = c.UserID,
                    UserName = c.UserName,
                    UserPosition = c.UserPosition,
                    UserDepartment = c.UserDepartment,
                    UserSalary = c.UserSalary,
                    UserStatus = c.UserStatus
                }).ToList().First();
            }
        }

        /// <summary>
        /// 获取全部员工的员工资料信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        List<ViewUserAsEmployee> IUserData.GetUserAsEmployee()
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Select(c => new ViewUserAsEmployee()
                {
                    UserID = c.UserID,
                    UserName = c.UserName,
                    UserPosition = c.UserPosition,
                    UserDepartment = c.UserDepartment,
                    UserSalary = c.UserSalary,
                    UserStatus = c.UserStatus
                }).ToList();
            }
        }
        /// <summary>
        /// 获取员工登录信息
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserLogin IUserData.GetUserLogin(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Where(c => c.UserID == userID).Select(c => new ViewUserLogin()
                {
                    UserID = c.UserID,
                    UserPassword = c.UserPassword
                }).ToList().First();
            }
        }

        /// <summary>
        /// 获取员工个人资料中可以自由修改的部分
        /// </summary>
        /// <param name="userID">员工编号</param>
        /// <returns></returns>
        ViewUserSelf IUserData.GetUserSelf(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Where(c => c.UserID == userID).Select(c => new ViewUserSelf()
                {
                    UserID = c.UserID,
                    Address = c.UserAddress,
                    Email = c.UserEmail,
                    PhoneNumber = c.UserPhoneNumber,
                    UserPassword = c.UserPassword
                }).ToList().First();
            }
        }

        /// <summary>
        /// 获取所有员工的全部信息
        /// </summary>
        /// <returns></returns>
        List<InfoUserSelf> IUserData.GetUserSelfInfos()
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.ToList();
            }
        }

        /// <summary>
        /// 获取单个用户的全部信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        InfoUserSelf IUserData.GetUserSelfInfos(int userID)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Find(userID);
            };
        }

        /// <summary>
        /// 获取所有员工信息中可以自由修改的部分
        /// </summary>
        /// <returns></returns>
        List<ViewUserSelf> IUserData.GetUserSelves()
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserSelves.Select(c => new ViewUserSelf()
                {
                    UserID = c.UserID,
                    Address = c.UserAddress,
                    Email = c.UserEmail,
                    PhoneNumber = c.UserPhoneNumber,
                    UserPassword = c.UserPassword
                }).ToList();
            }
        }

        /// <summary>
        /// 获取所有员工的资料更新记录
        /// </summary>
        /// <returns></returns>
        List<InfoUserUpdate> IUserData.GetUserUpdateInfos()
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                return db.UserUpdates.ToList();
            }
        }

        /// <summary>
        /// 更新用户资料
        /// </summary>
        /// <param name="userSelf">完整的员工资料实体</param>
        void IUserData.UpdateDetail(InfoUserSelf userSelf)
        {
            using (MicroERPContext db = new MicroERPContext())
            {
                var beingUpdate = db.UserSelves.Find(userSelf.UserID);
                beingUpdate.UserPassword = beingUpdate.UserPassword == userSelf.UserPassword ? beingUpdate.UserPassword : userSelf.UserPassword;
                beingUpdate.UserPhoneNumber = beingUpdate.UserPhoneNumber == userSelf.UserPhoneNumber ? beingUpdate.UserPhoneNumber : userSelf.UserPhoneNumber;
                beingUpdate.UserAddress = beingUpdate.UserAddress == userSelf.UserAddress ? beingUpdate.UserAddress : userSelf.UserAddress;
                beingUpdate.UserDepartment = beingUpdate.UserDepartment == userSelf.UserDepartment ? beingUpdate.UserDepartment : userSelf.UserDepartment;
                beingUpdate.UserName = beingUpdate.UserName == userSelf.UserName ? beingUpdate.UserName : userSelf.UserName;
                beingUpdate.UserPosition = beingUpdate.UserPosition == userSelf.UserPosition ? beingUpdate.UserPosition : userSelf.UserPosition;
                beingUpdate.UserSalary = beingUpdate.UserSalary == userSelf.UserSalary ? beingUpdate.UserSalary : userSelf.UserSalary;
                beingUpdate.UserStatus = beingUpdate.UserStatus == userSelf.UserStatus ? beingUpdate.UserStatus : userSelf.UserStatus;
                db.SaveChanges();
            }
        }


    }

}
