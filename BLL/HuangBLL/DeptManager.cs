using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
using DAL;
using DAL.HuangDAL;
namespace BLL.HuangBLL
{
   public  class DeptManager
    {
        public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            return DeptService. PageListDemo(pageindex, pagesize);
        }


        public static int GetRows()
        {
            return DeptService.GetRows();
        }


        public static int Del(int DeptId)
        {
            return DeptService.Del(DeptId);
        }

        public static int Add(Dept de)
        {
            return DeptService.Add(de);
        }

        public static IQueryable GetById(int id)
        {
            return DeptService.GetById(id);
        }

        public static int Edit(Dept de)
        {
            return DeptService.Edit(de);
        }
    }
}
