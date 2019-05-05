using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MicroERP.DAL;
using MicroERP.Model;

namespace MicroERP.Web.Areas.System.Controllers
{
    public class GoodsController : Controller
    {
        private MicroERPContext db = new MicroERPContext();
        public bool GetSessionInfo()//将Session中的登录信息获取到ViewBag的currentLoginInfo
        {
            var currentLoginUser = (ViewUserAsEmployee)Session["loginuser"];
            if (currentLoginUser == null)
                return false;
            ViewBag.currentLoginInfo = currentLoginUser;
            return true;
        }
        // GET: System/Goods
        public async Task<ActionResult> Index()
        {
            GetSessionInfo();
            var goodsOrders = db.GoodsOrders.Include(i => i.Funds).Include(i => i.GoodsConfirm).Include(i => i.RejectedOrder);
            return View(await goodsOrders.ToListAsync());
        }

        // GET: System/Goods/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoGoodsOrder infoGoodsOrder = await db.GoodsOrders.FindAsync(id);
            if (infoGoodsOrder == null)
            {
                return HttpNotFound();
            }
            GetSessionInfo();
            return View(infoGoodsOrder);
        }

        // GET: System/Goods/Create
        public ActionResult Create()
        {
            ViewBag.OrderID = new SelectList(db.FundsGoods, "FundsForGoodsID", "FundsState");
            ViewBag.OrderID = new SelectList(db.GoodsConfirms, "ConfirmID", "ConfirmType");
            ViewBag.OrderID = new SelectList(db.GoodsRejectedOrders, "RejectID", "RejectState");
            GetSessionInfo();
            return View();
        }

        // POST: System/Goods/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "OrderID,GoodsQuantity,GoodsTarget,GoodsUnitPrice,OrderTime,SaleNote")] InfoGoodsOrder infoGoodsOrder)
        {
            if (ModelState.IsValid)
            {
                db.GoodsOrders.Add(infoGoodsOrder);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.OrderID = new SelectList(db.FundsGoods, "FundsForGoodsID", "FundsState", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsConfirms, "ConfirmID", "ConfirmType", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsRejectedOrders, "RejectID", "RejectState", infoGoodsOrder.OrderID);
            GetSessionInfo();
            return View(infoGoodsOrder);
        }

        // GET: System/Goods/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InfoGoodsOrder infoGoodsOrder = await db.GoodsOrders.FindAsync(id);
            if (infoGoodsOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderID = new SelectList(db.FundsGoods, "FundsForGoodsID", "FundsState", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsConfirms, "ConfirmID", "ConfirmType", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsRejectedOrders, "RejectID", "RejectState", infoGoodsOrder.OrderID);
            GetSessionInfo();
            return View(infoGoodsOrder);
        }

        // POST: System/Goods/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "OrderID,GoodsQuantity,GoodsTarget,GoodsUnitPrice,OrderTime,SaleNote")] InfoGoodsOrder infoGoodsOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoGoodsOrder).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.OrderID = new SelectList(db.FundsGoods, "FundsForGoodsID", "FundsState", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsConfirms, "ConfirmID", "ConfirmType", infoGoodsOrder.OrderID);
            ViewBag.OrderID = new SelectList(db.GoodsRejectedOrders, "RejectID", "RejectState", infoGoodsOrder.OrderID);
            GetSessionInfo();
            return View(infoGoodsOrder);
        }
        
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    InfoGoodsOrder infoGoodsOrder = await db.GoodsOrders.FindAsync(id);
        //    db.GoodsOrders.Remove(infoGoodsOrder);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
