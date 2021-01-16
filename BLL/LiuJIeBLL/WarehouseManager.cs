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
    public class WarehouseManager
    {
            /// <summary>
            /// 分页查询Warehouse表所有数据
            /// </summary>
            /// <returns></returns>
            public static Model.Jie.PageList GetPageListWarehouse(int pageIndex, int pageSize)
        {
            return WarehouseSerivce.GetPageListWarehouse(pageIndex, pageSize);
        }
        /// <summary>
        /// Warehouse总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRowsWarehouse()
        {
            return WarehouseSerivce.GetRowsWarehouse();
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为1:待审核
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse1(int pageIndex, int pageSize)
        {
            return WarehouseSerivce.GetPageListWarehouse1(pageIndex, pageSize);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为2:审核通过
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse2(int pageIndex, int pageSize)
        {
            return WarehouseSerivce.GetPageListWarehouse2(pageIndex, pageSize);
        }

        /// <summary>
        /// 分页查询Warehouse表所有数据
        /// 状态为3:审核失败
        /// </summary>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouse3(int pageIndex, int pageSize)
        {
            return WarehouseSerivce.GetPageListWarehouse3(pageIndex, pageSize);
        }

        /// <summary>
        /// 根据时间区间查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouseShiJian(int pageIndex, int pageSize, DateTime date1, DateTime date2)
        {
            return WarehouseSerivce.GetPageListWarehouseShiJian(pageIndex, pageSize, date1, date2);
        }
        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListWarehouseBianHao(int pageIndex, int pageSize, string bianhao)
        {
            return WarehouseSerivce.GetPageListWarehouseBianHao(pageIndex, pageSize, bianhao);
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
        public static Model.Jie.PageList GetPageListWarehouseTiaoJian(int pageIndex, int pageSize, string bianhao, DateTime date1, DateTime date2)
        {
            return WarehouseSerivce.GetPageListWarehouseTiaoJian(pageIndex, pageSize, bianhao, date1, date2);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetDeleteWarehouse(int id)
        {
            return WarehouseSerivce.GetDeleteWarehouse(id);
        }
    }
}
