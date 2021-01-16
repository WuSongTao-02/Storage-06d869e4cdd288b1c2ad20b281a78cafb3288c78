using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;
using DAL.LiuJIeDAL;

namespace BLL.LiuJIeBLL
{
    public class ProbaictCatagoryManager
    {
        public static IQueryable GetProbaictCatagory()
        {
            return ProbaictCatagorySerivce.GetProbaictCatagory();
        }
        }
}
