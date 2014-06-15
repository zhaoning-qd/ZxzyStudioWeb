using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;
using System.Web.Security;

namespace MvcShopping.Controllers
{
    public class MemberController : Controller
    {
        /// <summary>
        /// 会员注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 写入会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register([Bind(Exclude="RegisterOn,AuthCode")]Member member)
        {
            return View();
        }

        /// <summary>
        /// 显示会员登录页面
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        /// <summary>
        /// 运行会员登陆
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string email,string password, string returnUrl)
        {
            if (ValidateUser(email,password))
            {
                FormsAuthentication.SetAuthCookie(email, false);
                if (string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "home");
                }
                else
                {
                    return Redirect(returnUrl);
                }
            }

            ModelState.AddModelError("","您输入的账号或密码错误");
            return View();
        }

        private bool ValidateUser(string eamil,string password)
        {
            throw new NotImplementedException();
        }

        public ActionResult Logout()
        {
            //清除窗体验证的cookies
            FormsAuthentication.SignOut();
            //清除所有曾经写入过的Session信息
            Session.Clear();

            return RedirectToAction("Index","home");
        }

    }
}
