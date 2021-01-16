using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using DAL.LiuMingDAL;

namespace BLL.LiuMingBLL
{
    public class StorehouseBLL
    {
        StorehouseDAL dal = new StorehouseDAL();


        //查询所有
        public static IQueryable GetAll11()
        {
            return StorehouseDAL.GetAll11();
        }

        #region 按条件查询
        public static PageList querid(int pageIndex, int pagesize, string SupName, string StName, string StoreNum)
        {
            return StorehouseDAL.querid(pageIndex,pagesize, SupName,StName, StoreNum);
        }
        #endregion

        public static int Add(Storehouse stroe)
        {
            return StorehouseDAL.Add(stroe);
        }



        }
}
