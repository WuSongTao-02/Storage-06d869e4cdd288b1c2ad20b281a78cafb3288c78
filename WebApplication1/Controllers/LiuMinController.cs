using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL.LiuMingBLL;

namespace WebApplication1.Controllers
{
    public class LiuMinController : Controller
    {
        // GET: LiuMin

        #region 库位管理
        public ActionResult Index()
        {
            return View();
        }

        //库位管理查询所有
        public ActionResult GetAll11()
        {
            return Json(StorehouseBLL.GetAll11(), JsonRequestBehavior.AllowGet);
        }

        //按条件查询
        public ActionResult querid(int pageIndex, int pagesize, string SupName, string StName, string StoreNum)
        {
            return Json(StorehouseBLL.querid(pageIndex, pagesize, SupName, StName, StoreNum), JsonRequestBehavior.AllowGet);
        }

        //新增
        public ActionResult Add(Storehouse stroe)
        {
            return Json(StorehouseBLL.Add(stroe), JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region 客户管理
        //客户表
        public ActionResult CustIndex()
        {
            return View();
        }
        //客户管理表查询所有
        public ActionResult CustGetAll()
        {
            return Json(CustomerBLL.CustGetAll(), JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 供应商管理
        public ActionResult VendorIndex()
        {
            return View();
        }
        //供应商管理查询所有
        public ActionResult GetAll()
        {
            return Json(VendorBLL.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetRows()
        {
            return Json(VendorBLL.GetRows(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult PageListDemo(int pageIndex, int PageSize)
        {
            return Json(VendorBLL.PageListDemo(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        //根据供应商用户名或工号查询
        public ActionResult ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            return Json(VendorBLL.ShowByName(pageIndex, pageSize, VenId, VenName), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowByName1(int VenId)
        {
            return Json(VendorBLL.ShowByName1(VenId), JsonRequestBehavior.AllowGet);
        }
        public ActionResult aaaa(int VenId)
        {
            return Json(VendorBLL.ShowByName1(VenId), JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}