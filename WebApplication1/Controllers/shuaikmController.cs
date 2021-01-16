using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace WebApplication1.Controllers
{
    public class shuaikmController : Controller
    {
        // GET: shuaikm
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult yiku() {
            return View();
        }
        public ActionResult pandian() {
            return View();
        }
        public ActionResult cate() {
            return View();
        }

        public ActionResult ChaXun() {

            return Json(BLL.ShuaiBLL.BaoSunManager.ChaXun(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRows() {
            return Json(BLL.ShuaiBLL.BaoSunManager.GetRows(), JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetRows1() {
            return Json(BLL.ShuaiBLL.YiKuManager.GetRows1(),JsonRequestBehavior.AllowGet);
        
        }
        public ActionResult edit(int id)
        {
            return Json(BLL.ShuaiBLL.BaoSunManager.edit(id),JsonRequestBehavior.AllowGet);
        }
        public ActionResult yikuedit(int id) {
            return Json(BLL.ShuaiBLL.YiKuManager.yikuedit(id),JsonRequestBehavior.AllowGet);
        
        }
            public ActionResult GetPageList(int PageIndex, int PageSize){

            return Json(BLL.ShuaiBLL.BaoSunManager.GetPageList(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
            }

        public ActionResult YikuPageList(int PageIndex, int PageSize) {
            return Json(BLL.ShuaiBLL.YiKuManager.YikuPageList(PageIndex,PageSize),JsonRequestBehavior.AllowGet) ;
        }

        public ActionResult GetPageList1(int PageIndex, int PageSize, string name) {
            return Json(BLL.ShuaiBLL.BaoSunManager.GetPageList1(PageIndex,PageSize,name),JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChaXun2(string name)
        {
            return Json(BLL.ShuaiBLL.BaoSunManager.ChaXun2(name),JsonRequestBehavior.AllowGet);
        
        }
        public ActionResult Yikuchaxun() {
            return Json(BLL.ShuaiBLL.YiKuManager.Yikuchaxun(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult YikuPageList1(int PageIndex, int PageSize, string name) {
            return Json(BLL.ShuaiBLL.YiKuManager.YikuPageList1(PageIndex,PageSize,name),JsonRequestBehavior.AllowGet);
        }

        public ActionResult YikuPageList2(int PageIndex,int PageSize,string name, DateTime sname, DateTime sname2) {
            return Json(BLL.ShuaiBLL.YiKuManager.YikuPageList2(PageIndex,PageSize,name,sname,sname2),JsonRequestBehavior.AllowGet);
        }

        public ActionResult YikuPageList3(int PageIndex, int PageSize, DateTime sname, DateTime sname2)
        { 
        return Json(BLL.ShuaiBLL.YiKuManager.YikuPageList3(PageIndex,PageSize,sname,sname2),JsonRequestBehavior.AllowGet );
        }
        public ActionResult querydaishenhe(int PageIndex, int PageSize) {
            return Json(BLL.ShuaiBLL.YiKuManager.querydaishenhe(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Querytongguo(int PageIndex, int PageSize) {
            return Json(BLL.ShuaiBLL.YiKuManager.Querytongguo(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Queryshibai(int PageIndex, int PageSize) {
            return Json(BLL.ShuaiBLL.YiKuManager.Queryshibai(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
        
        }
        }
}