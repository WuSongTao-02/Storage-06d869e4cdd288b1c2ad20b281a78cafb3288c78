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
    public class VendorBLL
    {
        public static IQueryable GetAll()
        {
            return VendorDAL.GetAll();
        }
        public static int GetRows()
        {
            return VendorDAL.GetRows();
        }
        public static PageList PageListDemo(int pageIndex, int PageSize)
        {
            return VendorDAL.PageListDemo(pageIndex, PageSize);
        }

        public static PageList ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            return VendorDAL.ShowByName(pageIndex, pageSize, VenId, VenName);
        }
        public static IQueryable ShowByName1(int VenId)
        {
            return VendorDAL.ShowByName1(VenId);
        }
    }
}
