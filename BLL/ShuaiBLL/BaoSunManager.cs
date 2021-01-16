using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL.ShuaiBLL
{
   public  class BaoSunManager
    {

        public static IQueryable ChaXun()
        {
            return DAL.ShuaiDAL.BaoSunService.ChaXun();
        }
        public static ShuaiPageList GetPageList(int PageIndex, int PageSize)
        {
            return DAL.ShuaiDAL.BaoSunService.GetPageList(PageIndex,PageSize);
        }
        public static int GetRows()
        {
            return DAL.ShuaiDAL.BaoSunService.GetRows();
        }
        public static int edit(int id)
        {
            return DAL.ShuaiDAL.BaoSunService.edit(id);
        }
        public static ShuaiPageList GetPageList1(int PageIndex, int PageSize, string name) {

            return DAL.ShuaiDAL.BaoSunService.GetPageList1(PageIndex,PageSize,name);
        }
        public static IQueryable ChaXun2(string name) {
            return DAL.ShuaiDAL.BaoSunService.ChaXun2(name);
        }
        }
}
