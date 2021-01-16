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
    public class DeliverManager
    {
        /// <summary>
        /// Warehouse总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRowsDeliver()
        {
            return DeliverSerivce.GetRowsDeliver();
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliver(int pageIndex, int pageSize)
        {
            return DeliverSerivce.GetPageListDeliver(pageIndex,pageSize);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为1:待审核
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliver1(int pageIndex, int pageSize)
        {
            return DeliverSerivce.GetPageListDeliver1(pageIndex,pageSize);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为2:审核通过
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliver2(int pageIndex, int pageSize)
        {
            return DeliverSerivce.GetPageListDeliver2(pageIndex,pageSize);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为3:审核失败
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliver3(int pageIndex, int pageSize)
        {
            return DeliverSerivce.GetPageListDeliver3(pageIndex,pageSize);
        }

        /// <summary>
        /// 根据时间区间查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliverShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            return DeliverSerivce.GetPageListDeliverShiJian(pageIndex,pageSize,date1,date2);
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListDeliverBianHao(int pageIndex, int pageSize, string bianhao)
        {
            return DeliverSerivce.GetPageListDeliverBianHao(pageIndex,pageSize,bianhao);
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
            return DeliverSerivce.GetPageListDeliverTiaoJian(pageIndex,pageSize,bianhao,date1,date2);
        }

            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public static int GetDeleteDeliver(int id)
        {
            return DeliverSerivce.GetDeleteDeliver(id);
        }

        }
}
