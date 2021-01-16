using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.ShuaiDAL
{
   public  class BaoSunService
    {
        public static IQueryable ChaXun() {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = from p in hh.Damage
                      orderby p.Damid
                      select new { 
                      Damid=p.Damid,
                      DamType=p.DamType,
                      DamOrder=p.DamOrder,
                      DamPerson=p.DamPerson,
                      AudiId=p.AudiId,
                      CreateTime=p.CreateTime,
                      IsDelete=p.IsDelete,
                      Remake=p.Remake,
                      };
            return obj;
        }
        public static IQueryable ChaXun2(string name)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = from p in hh.Damage
                      where p.DamType.Contains(name)
                      orderby p.Damid
                      select new
                      {
                          Damid = p.Damid,
                          DamType = p.DamType,
                          DamOrder = p.DamOrder,
                          DamPerson = p.DamPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                      };
            return obj;
        }

        public static int GetRows() {
            CangChuEntities1 hh = new CangChuEntities1();
            return hh.Damage.Count();
        }


        public static int edit(int id) {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = hh.Damage.Where(p =>p.Damid== id).FirstOrDefault();
            if (obj!=null) {

                obj.IsDelete = 1;
            
            }
            return hh.SaveChanges();
        }
        public static ShuaiPageList GetPageList1(int PageIndex, int PageSize,string name)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Damage
                      where p.DamType.Contains(name)
                      orderby p.Damid
                      select new
                      {
                          Damid = p.Damid,
                          DamType = p.DamType,
                          DamOrder = p.DamOrder,
                          DamPerson = p.DamPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        public static ShuaiPageList GetPageList(int PageIndex,int PageSize) {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Damage
                      where p.IsDelete==0
                      orderby p.Damid 
                      select new {
                          Damid = p.Damid,
                          DamType = p.DamType,
                          DamOrder = p.DamOrder,
                          DamPerson = p.DamPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
    }
}
