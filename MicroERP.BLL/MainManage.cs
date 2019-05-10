﻿using MicroERP.DAL;
using MicroERP.IDAL;
using MicroERP.Web.Areas.System.Models;
using System;
using System.Linq;

namespace MicroERP.BLL
{
    public class MainManage
    {
        private readonly IUserData userData;
        private readonly IGoodsData goodsData;
        public MainManage()
        {
            this.userData = new UserData();
            this.goodsData = new GoodsData();
        }
        public MainIndexViewModel GetMainIndex()
        {
            MainIndexViewModel data = new MainIndexViewModel();
            data.EmployeeCount = userData.GetUserAsEmployee().FindAll(c => c.UserStatus == "在职").Count-1;
            data.OrderCount = goodsData.GetAllGoodsOrder().Count();
            data.TodoCount = goodsData.GetAllGoodsConfirm().Count();
            data.UnderCheckCount = goodsData.GetAllGoodsRejectedOrder().Count();
            return data;
        }
        public TableViewModel GetMainTable()
        {
            TableViewModel data = new TableViewModel();
            var table = goodsData.GetAllGoodsOrder();
            if(table.Count>13)
            table = table.GetRange(1, 13);
            table = table.OrderByDescending(c => c.OrderTime).ToList();
            int i = 0;
            foreach (var item in table)
            {
                if (String.IsNullOrEmpty(data.TDate[i]))
                {
                    data.TDate[i] = item.OrderTime.Date.ToString();
                    data.TNumbers[i] = 0;
                }
                if (data.TDate[i] == item.OrderTime.Date.ToString())
                {
                    data.TNumbers[i] = data.TNumbers[i] + item.GoodsQuantity;
                }
                else
                {
                    i += 1;
                    data.TDate[i] = item.OrderTime.Date.ToString();
                    data.TNumbers[i] = 0;
                    data.TNumbers[i] = data.TNumbers[i] + item.GoodsQuantity;
                }
            }
            return data;
        }
    }
}
