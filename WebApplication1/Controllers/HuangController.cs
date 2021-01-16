using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Huang;
using BLL.HuangBLL;
namespace WebApplication1.Controllers
{
    public class HuangController : Controller
    {
        // GET: Huang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Department()
        {
            return View();
        }

        public ActionResult DemoPageList(int pageindex, int pagesize)
        {
            return Json(DeptManager.PageListDemo(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRows()
        {
            return Json(DeptManager.GetRows(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Del(int DeptId)
        {
            return Json(DeptManager.Del(DeptId), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Dept d)
        {
            
            
            return Json(DeptManager.Add(d), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(Dept d)
        {
            return Json(DeptManager.Edit(d), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetById(int id)
        {
            return Json(DeptManager.GetById(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update()
        {
            return View();
        }

    }
}