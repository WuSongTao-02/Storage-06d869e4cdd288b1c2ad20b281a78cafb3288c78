using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Jie;
using BLL.LiuJIeBLL;

namespace WebApplication1.Controllers
{
    public class LiuJieController : Controller
    {
        // GET: LiuJie
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 产品页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMian() {
            return View();
        }

        /// <summary>
        /// 产品新增页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianAdd()
        {
            return View();
        }

        /// <summary>
        /// 产品修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianUpdate()
        {
            return View();
        }

        /// <summary>
        /// 产品分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListProbaict(int pageIndex, int pageSize) {
            return Json(ProbaictManager.PageListProbaict(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品数据条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRowsProbaict() {
            return Json(ProbaictManager.GetRows(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品条件分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public ActionResult GetTiaoJianPageListProbaict(int pageIndex, int pageSize,string ProId) {
            return Json(ProbaictManager.TiaoJianPageListProbaict(pageIndex,pageSize,ProId),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品删除
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDeleteProbaict(string  id) {
            return Json(ProbaictManager.GetDelete(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品修改
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUpdateProbaict(Probaict pr) {
            return Json(ProbaictManager.Update(pr),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public ActionResult GetAddProbaict(Probaict pr) {
            return Json(ProbaictManager.Add(pr),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据id查询产品
        /// </summary>
        /// <returns></returns>
        public ActionResult GetByIdProbaict(string id) {
            return Json(ProbaictManager.GetById(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询ProbaictCatagory表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetProbaictCatagory() {
            return Json(ProbaictCatagoryManager.GetProbaictCatagory(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询Unit表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUnit() {
            return Json(UnitManager.GetUnit(),JsonRequestBehavior.AllowGet);
        }

        //入库页面
        public ActionResult RuKuYeMian() {
            return View();
        }

        //入库新增页面
        public ActionResult RuKuYeMianAdd()
        {
            return View();
        }

        /// <summary>
        /// Warehouse表总条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRowsWarehouse() {
            return Json(WarehouseManager.GetRowsWarehouse(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询入库分页Warehouse所有数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPageListWarehouse(int pageIndex, int pageSize) {
            return Json(WarehouseManager.GetPageListWarehouse(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为1:待审核
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouse1(int pageIndex, int pageSize)
        {
            return Json(WarehouseManager.GetPageListWarehouse1(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为2:审核通过
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouse2(int pageIndex, int pageSize)
        {
            return Json(WarehouseManager.GetPageListWarehouse2(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为3:审核失败
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouse3(int pageIndex, int pageSize)
        {
            return Json(WarehouseManager.GetPageListWarehouse3(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据时间区间查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouseShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            return Json(WarehouseManager.GetPageListWarehouseShiJian(pageIndex,pageSize,date1,date2),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouseBianHao(int pageIndex, int pageSize, string bianhao)
        {
            return Json(WarehouseManager.GetPageListWarehouseBianHao(pageIndex,pageSize,bianhao),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据编号时间两个条件进行查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="bianhao"></param>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public ActionResult GetPageListWarehouseTiaoJian(int pageIndex, int pageSize, string bianhao, DateTime date1, DateTime date2)
        {
            return Json(WarehouseManager.GetPageListWarehouseTiaoJian(pageIndex,pageSize,bianhao,date1,date2),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetDeleteWarehouse(int id) {
            return Json(WarehouseManager.GetDeleteWarehouse(id),JsonRequestBehavior.AllowGet);
        }
            //入库修改页面
        public ActionResult RuKuYeMianUpdate()
        {
            return View();
        }

        /// <summary>
        /// 出库页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuKuYeMian() {
            return View();
        }

        /// <summary>
        /// Warehouse表总条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRowsDeliver()
        {
            return Json(DeliverManager.GetRowsDeliver(), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询入库分页Warehouse所有数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPageListDeliver(int pageIndex, int pageSize)
        {
            return Json(DeliverManager.GetPageListDeliver(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为1:待审核
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliver1(int pageIndex, int pageSize)
        {
            return Json(DeliverManager.GetPageListDeliver1(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为2:审核通过
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliver2(int pageIndex, int pageSize)
        {
            return Json(DeliverManager.GetPageListDeliver2(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为3:审核失败
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliver3(int pageIndex, int pageSize)
        {
            return Json(DeliverManager.GetPageListDeliver3(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据时间区间查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliverShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            return Json(DeliverManager.GetPageListDeliverShiJian(pageIndex,pageSize,date1,date2),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliverBianHao(int pageIndex, int pageSize, string bianhao)
        {
            return Json(DeliverManager.GetPageListDeliverBianHao(pageIndex,pageSize,bianhao),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据编号时间两个条件进行查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="bianhao"></param>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public ActionResult GetPageListDeliverTiaoJian(int pageIndex, int pageSize, string bianhao, DateTime date1, DateTime date2)
        {
            return Json(DeliverManager.GetPageListDeliverTiaoJian(pageIndex,pageSize,bianhao,date1,date2),JsonRequestBehavior.AllowGet);
        }

            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public ActionResult GetDeleteDeliver(int id)
        {
            return Json(DeliverManager.GetDeleteDeliver(id),JsonRequestBehavior.AllowGet);
        }

            /// <summary>
            /// 出库新增页面
            /// </summary>
            /// <returns></returns>
            public ActionResult ChuKuYeMianAdd()
        {
            return View();
        }

        /// <summary>
        /// 出库修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuKuYeMianUpdate()
        {
            return View();
        }
    }
}