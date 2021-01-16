using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;

namespace DAL.LiuJIeDAL
{
    public class DeliverSerivce
    {
        /// <summary>
        /// Warehouse总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRowsDeliver()
        {
            CangChuEntities1 entity = new CangChuEntities1();
            return entity.Deliver.Count();
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliver(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.IsDelete == 0
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliver1(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.AudiId == 1
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliver2(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.AudiId == 2
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliver3(int pageIndex, int pageSize)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.AudiId == 3
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliverShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.CreateTime >= date1 && p.CreateTime <= date2
                      orderby p.AudiId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliverBianHao(int pageIndex, int pageSize, string bianhao)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.DeliaOrder.Contains(bianhao)
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static Model.Jie.PageList GetPageListDeliverTiaoJian(int pageIndex, int pageSize, string bianhao, DateTime date1, DateTime date2)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Deliver
                      where p.DeliaOrder.Contains(bianhao) && p.CreateTime >= date1 && p.CreateTime <= date2
                      orderby p.DeliId
                      select new
                      {
                          DeliId = p.DeliId,
                          DeliType = p.DeliType,
                          DeliaOrder = p.DeliaOrder,
                          DelDate = p.DelDate,
                          CusId = from pp in entity.Customer where p.CusId == pp.CusId select pp.CusName,
                          DeliPerson = p.DeliPerson,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                          AudiId = from ppp in entity.Auditing where p.AudiId == ppp.AudiId select ppp.AudiName
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
        public static int GetDeleteDeliver(int id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Deliver where p.AudiId == id select p).First();
            if (obj != null)
            {
                obj.IsDelete = 1;
            }
            return entity.SaveChanges();
        }
    }
}
