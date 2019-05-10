using MicroERP.BLL;
using MicroERP.DAL;
using MicroERP.Model;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MicroERP.Web.Areas.System.Controllers
{
    public class GoodsController : Controller
    {
        private readonly MicroERPContext db = new MicroERPContext();
        private readonly GoodsManage goodsManage;
        public GoodsController(GoodsManage manage)
        {
            goodsManage = manage;
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)//获取用户登录信息
        {
            base.OnActionExecuting(filterContext);
            var currentLoginUser = Session["loginuser"] == null ? null : (ViewUserAsEmployee)Session["loginuser"];
            if (currentLoginUser == null)//如果没有登录，跳转到登录界面
            {
                filterContext.Result = Redirect("/Home/Login/");
            }
            else//如果是已离职员工，则跳转到主界面
            {
                if (currentLoginUser.UserStatus == "离职")
                {
                    filterContext.Result = RedirectToAction("Login", "Home", new { msg = "您已经办理离职，如有特殊情况请与人事部沟通。" });
                }
            }
            ViewBag.currentLoginInfo = currentLoginUser;
        }
        public ActionResult Index()
        {
            return View(goodsManage.GetOrderList());
        }

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
            return View(infoGoodsOrder);
        }

        [HttpGet]
        public ActionResult CreateOrder()
        {
            ViewBag.selListTyp= OrderTypeDropDownList().AsEnumerable();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateOrder(InfoGoodsOrder infoGoodsOrder)
        {
            if (ModelState.IsValid)
            {
                db.GoodsOrders.Add(infoGoodsOrder);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

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
            return View(infoGoodsOrder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(InfoGoodsOrder infoGoodsOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoGoodsOrder).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(infoGoodsOrder);
        }

        public async Task<ActionResult> Delete(int? id)
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
            return View(infoGoodsOrder);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            InfoGoodsOrder infoGoodsOrder = await db.GoodsOrders.FindAsync(id);
            db.GoodsOrders.Remove(infoGoodsOrder);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #region 下拉表单
        public SelectList OrderTypeDropDownList()
        {
            return new SelectList(goodsManage.GetOrderType());
        }
        #endregion

    }
}
