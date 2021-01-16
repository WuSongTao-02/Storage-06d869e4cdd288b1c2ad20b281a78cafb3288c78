using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;
using DAL.LiuJIeDAL;

namespace BLL.LiuJIeBLL
{
    public class ProbaictManager
    {
        /// <summary>
        /// 数据分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList PageListProbaict(int pageIndex, int pageSize)
        {
            return ProbaictSerivce.PageListProbaict(pageIndex, pageSize);
        }

        /// <summary>
        /// 根据条件分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public static Model.Jie.PageList TiaoJianPageListProbaict(int pageIndex, int pageSize, string ProId)
        {
            return ProbaictSerivce.TiaoJianProidPageListProbaict(pageIndex,pageSize,ProId);
        }

            /// <summary>
            /// 总条数
            /// </summary>
            /// <returns></returns>
            public static int GetRows()
        {
            return ProbaictSerivce.GetRows();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetDelete(string  id)
        {
            return ProbaictSerivce.GetDelete(id);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int Add(Probaict pr)
        {
            return ProbaictSerivce.Add(pr);
        }

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IQueryable GetById(string id)
        {
            return ProbaictSerivce.GetById(id);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public static int Update(Probaict pr)
        {
            return ProbaictSerivce.Update(pr);
        }
        }
}
