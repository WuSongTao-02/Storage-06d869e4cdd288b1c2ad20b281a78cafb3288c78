using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.LiuMingDAL;
using Model;
namespace BLL.LiuMingBLL
{
   public class CustomerBLL
    {
        public static IQueryable CustGetAll()
        {
            return CustomerDAL.CustGetAll();
        }
        }
}
