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
   public  class RoleManager
    {

        public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            return RoleService.PageListDemo(pageindex, pagesize);
        }


        public static int GetRows()
        {
            return RoleService.GetRows();
        }


        public static int Del(int Id)
        {
            return RoleService.Del(Id);
        }

        public static int Add(Role r)
        {
            return RoleService.Add(r);
        }

        public static IQueryable GetById(int id)
        {
            return RoleService.GetById(id);
        }

        public static int Edit(Role r)
        {
            return RoleService.Edit(r);
        }
    }
}
