using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;

namespace DAL.LiuJIeDAL
{
    public class WarehouseSerivce
    {
        /// <summary>
        /// Warehouse总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRowsWarehouse()
        {
            CangChuEntities1 entity = new CangChuEntities1();
            return entity.Warehouse.Count();
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse(int pageIndex, int pageSize) {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.IsDelete == 0
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为1:待审核
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse1(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.AudiId == 1
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为2:审核通过
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse2(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.AudiId == 2
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为3:审核失败
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse3(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.AudiId == 3
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 根据时间区间查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouseShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.CreateTime >= date1 && p.CreateTime <= date2
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouseBianHao(int pageIndex, int pageSize, string bianhao)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.WarOrder.Contains(bianhao)
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
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
        public static Model.Jie.PageList GetPageListWarehouseTiaoJian(int pageIndex, int pageSize, string bianhao,DateTime date1,DateTime date2) {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Warehouse
                      where p.WarOrder.Contains(bianhao) && p.CreateTime >= date1 && p.CreateTime <= date2
                      orderby p.WarId
                      select new
                      {
                          WarId = p.WarId,
                          WarType = p.WarType,
                          WarOrder = p.WarOrder,
                          WarPerson = p.WarPerson,
                          VenId = from pp in entity.Vendor where p.VenId == pp.VenId select pp.VenName,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetDeleteWarehouse(int id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Warehouse where p.WarId == id select p).First();
            if (obj != null)
            {
                obj.IsDelete = 1;
            }
            return entity.SaveChanges();
        }

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetById(int id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Warehouse
                      where p.WarId == id
                      select new
                      {
                          RuKuDanHao = p.WarId,
                          RuKuLeiXing = p.WarType,
                          ShenHeZhuanTai = from pp in entity.Auditing where p.AudiId == pp.AudiId select pp.AudiName,
                          GongYingShangBianHao = from ppp in entity.Vendor where p.VenId == ppp.VenId select ppp.VenId,
                          GongYingShangMingCheng = from pppp in entity.Vendor where p.VenId == pppp.VenId select pppp.VenName,
                          LianXiRen = from ppppp in entity.Vendor where p.VenId == ppppp.VenId select ppppp.VenPerson,
                          ChuangJianRen = p.WarPerson,
                          ChuangJianShiJian = p.CreateTime,
                          DianHua = from pppppp in entity.Vendor where p.VenId == pppppp.VenId select pppppp.VenTel,
                          BeiZhu = p.Remake,

                      };
            return obj;
        }
    }
}

