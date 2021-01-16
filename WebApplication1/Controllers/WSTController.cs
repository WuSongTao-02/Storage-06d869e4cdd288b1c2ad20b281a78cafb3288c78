using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace WebApplication1.Controllers
{
    public class WSTController : Controller
    {
        // GET: WST
       //登录页面
        public ActionResult Login()
        {
            Session.Clear();
            return View();
        }
        //登录
        public ActionResult Logins(string name, string pwd) {
            if (BLL.WstBLL.WstLoginBLL.Login(name, pwd) > 0) {
                Session["name"] =name;
            }
            return Json(BLL.WstBLL.WstLoginBLL.Login(name, pwd), JsonRequestBehavior.AllowGet);
            
        }

        //首页
         public ActionResult Index() {
            string UserName = Session["name"].ToString();
            ViewBag.UserNames = UserName;
         
            return View();
        }


        public ActionResult password() {
            return View();
        }

        

        public ActionResult Users(string UserName) {
            return Json(BLL.WstBLL.WstLoginBLL.GetUserName(UserName), JsonRequestBehavior.AllowGet);
        }

        //修改密码
        public ActionResult UpdataPwds(int id, string pwd) {
            return Json(BLL.WstBLL.WstLoginBLL.UpdatePwd(id, pwd), JsonRequestBehavior.AllowGet);
        }

        //个人信息
        public ActionResult UserMsessage()
        {
            return View();
        }
        //修改个人信息
        public ActionResult UserMessages(Admin admin)
        {
            return Json(BLL.WstBLL.WstLoginBLL.UpdataUser(admin), JsonRequestBehavior.AllowGet);
        }
    }
}