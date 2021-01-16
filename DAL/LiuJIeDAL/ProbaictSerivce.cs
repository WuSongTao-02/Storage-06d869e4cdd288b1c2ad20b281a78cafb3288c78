using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;

namespace DAL.LiuJIeDAL
{
    public class ProbaictSerivce
    {
        static CangChuEntities1 entity = new CangChuEntities1();

        /// <summary>
        /// 数据分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList PageListProbaict(int pageIndex, int pageSize) {
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Probaict
                      where p.IsDelete == 0
                      orderby p.ProId
                      select new
                      {
                          ProId = p.ProId,
                          ProName = p.ProName,
                          ProPrice = p.ProPrice,
                          PorGuiGe = p.PorGuiGe,
                          ProCId = from pp in entity.ProbaictCatagory where p.ProCId == pp.ProCId select pp.ProCName,
                          UnId = from ppp in entity.Unit where p.UnId == ppp.UnId select ppp.UnName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          ProNumber = p.ProNumber,
                          ProJinhuo = p.ProJinhuo,
                          ProChuhuo = p.ProChuhuo,
                          ProBaosun = p.ProBaosun,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 根据条件产品编号分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public static Model.Jie.PageList TiaoJianProidPageListProbaict(int pageIndex, int pageSize,string ProId)
        {
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.Probaict
                      where p.ProId == ProId
                      orderby p.ProId
                      select new
                      {
                          ProId = p.ProId,
                          ProName = p.ProName,
                          ProPrice = p.ProPrice,
                          PorGuiGe = p.PorGuiGe,
                          ProCId = from pp in entity.ProbaictCatagory where p.ProCId == pp.ProCId select pp.ProCName,
                          UnId = from ppp in entity.Unit where p.UnId == ppp.UnId select ppp.UnName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          ProNumber = p.ProNumber,
                          ProJinhuo = p.ProJinhuo,
                          ProChuhuo = p.ProChuhuo,
                          ProBaosun = p.ProBaosun,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 数据总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows() {
            return entity.Probaict.Count();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public static int GetDelete(string id) {
            var obj = (from p in entity.Probaict where p.ProId == id select p).First();
            if (obj != null)
            {
                obj.IsDelete = 1;
            }
            return entity.SaveChanges();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public static int Add(Probaict pr) {
            entity.Probaict.Add(pr);
            return entity.SaveChanges();
        }

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetById(string id) {
            var obj = from p in entity.Probaict
                      where p.ProId == id
                      select new
                      {
                          ProId = p.ProId,
                          ProName = p.ProName,
                          ProPrice = p.ProPrice,
                          PorGuiGe = p.PorGuiGe,
                          ProCId = from pp in entity.ProbaictCatagory where p.ProCId == pp.ProCId select pp.ProCName,
                          UnId = from ppp in entity.Unit where p.UnId == ppp.UnId select ppp.UnName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          ProNumber = p.ProNumber,
                          ProJinhuo = p.ProJinhuo,
                          ProChuhuo = p.ProChuhuo,
                          ProBaosun = p.ProBaosun,
                          Remake = p.Remake
                      };
            return obj;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public static int Update(Probaict r) {
            var obj = (from p in entity.Probaict where p.ProId == r.ProId select p).First();
            obj.ProId = r.ProId;
            obj.ProName = r.ProName;
            obj.ProPrice = r.ProPrice;
            obj.PorGuiGe = r.PorGuiGe;
            obj.ProCId = r.ProCId;
            obj.UnId = r.UnId;
            obj.CreateTime = r.CreateTime;
            obj.IsDelete = r.IsDelete;
            obj.ProNumber = r.ProNumber;
            obj.ProJinhuo = r.ProJinhuo;
            obj.ProChuhuo = r.ProChuhuo;
            obj.ProBaosun = r.ProBaosun;
            obj.Remake = r.Remake;
            return entity.SaveChanges();
        }
    }
}
