using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 客户管理
    /// </summary>
   public class CustomerDAL
    {
        #region 查询所有
        public static IQueryable CustGetAll()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Customer
                      select new
                      {
                          CusId=p.CusId,
                          CusName=p.CusName,
                          CusTel=p.CusTel,
                          CreateTime=p.CreateTime
                      };
            return obj;
        }
        #endregion
    }
}
