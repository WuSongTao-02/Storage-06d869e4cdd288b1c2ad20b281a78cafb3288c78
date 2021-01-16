using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.LiuJIeDAL;

namespace BLL.LiuJIeBLL
{
    public class UnitManager
    {
        public static IQueryable GetUnit()
        {
            return UnitSerivce.GetUnit();
        }
        }
}
