using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShopping.Controllers
{
    [Authorize] //登录会员才能使用订单结账功能
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        //显示完成订单的窗体页面
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Complete(FormCollection form)
        {
            //TODO:将订单信息功能购物车信息写入数据库

            //TODO:订单完成后必须清空现有购物车信息

            //订单完成后回到网站首页
            return RedirectToAction("Index","home");
        }

    }
}
