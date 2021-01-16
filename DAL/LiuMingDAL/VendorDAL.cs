using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 供应商管理
    /// </summary>
    public class VendorDAL
    {
        /// <summary>
        /// 获取数据表的总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            return contxt.Vendor.Count();
        }

        public static PageList PageListDemo(int pageIndex, int PageSize)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in contxt.Vendor
                      orderby p.VenId
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          Remake = p.Remake
                      };
            //设置分页数据
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);

            int rows = contxt.Vendor.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        #region 查询所有
        public static IQueryable GetAll()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      select new
                      {
                            VenId=p.VenId,
                            VenType=p.VenType,
                            VenName=p.VenName,
                            VenTel=p.VenTel,
                            VenEmain=p.VenEmain,
                            VenPerson=p.VenPerson,
                            VenAddress=p.VenAddress,
                            Remake=p.Remake

                      };
            return obj;
        }
        #endregion

        #region 根据编号或名称进行查询
        //
        public static PageList ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            PageList list = new PageList();
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      orderby p.VenId
                      where p.VenId == VenId || p.VenName == VenName
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          Remake = p.Remake
                      };
            list.Datalist = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int row = contxt.Vendor.Count();
            list.PageCount = row % pageSize == 0 ? row / pageSize : row / pageSize + 1;
            return list;
        }
        #endregion

        public static IQueryable ShowByName1(int VenId)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      where p.VenId == VenId 
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          Remake = p.Remake
                      };
            return obj;
        }
    }
}
