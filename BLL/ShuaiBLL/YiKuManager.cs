using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL.ShuaiBLL
{
     public class YiKuManager
     {
        public static IQueryable Yikuchaxun() {
            return DAL.ShuaiDAL.YiKuService.Yikuchaxun();
        }
        public static int GetRows1() {
            return DAL.ShuaiDAL.YiKuService.GetRows1();
        }

        public static ShuaiPageList YikuPageList(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.YiKuService.YikuPageList(PageIndex,PageSize);
        }

        public static int yikuedit(int id) {
            return DAL.ShuaiDAL.YiKuService.yikuedit(id);
        }
        public static ShuaiPageList YikuPageList1(int PageIndex, int PageSize, string name) {
            return DAL.ShuaiDAL.YiKuService.YikuPageList1(PageIndex,PageSize,name);
        }

        public static ShuaiPageList YikuPageList2(int PageIndex, int PageSize, string name, DateTime sname, DateTime sname2)

        {
            return DAL.ShuaiDAL.YiKuService.YikuPageList2(PageIndex,PageSize,name,sname,sname2);
        }

        public static ShuaiPageList YikuPageList3(int PageIndex, int PageSize, DateTime sname, DateTime sname2)
        {
            return DAL.ShuaiDAL.YiKuService.YikuPageList3(PageIndex,PageSize,sname,sname2);
        }

        public static ShuaiPageList querydaishenhe(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.YiKuService.querydaishenhe(PageIndex, PageSize);
        }
        public static ShuaiPageList Querytongguo(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.YiKuService.Querytongguo(PageIndex,PageSize);
        }
        public static ShuaiPageList Queryshibai(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.YiKuService.Queryshibai(PageIndex,PageSize);
        }

        }
}
