using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.LiuJIeDAL
{
    public class UnitSerivce
    {
        static CangChuEntities1 entity = new CangChuEntities1();

        public static IQueryable GetUnit() {
            var obj = from p in entity.Unit
                      select new 
                      {
                          UnId = p.UnId,
                          UnName = p.UnName,
                          IsDelete = p.IsDelete
                      };
            return obj;
        }
    }
}
