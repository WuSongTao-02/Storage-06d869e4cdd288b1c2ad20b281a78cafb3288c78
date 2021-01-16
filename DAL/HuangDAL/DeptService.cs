using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
namespace DAL.HuangDAL
{
   public  class DeptService
    {
        public static int GetRows()
        {
            
            CangChuEntities1 entities = new CangChuEntities1();
            return entities.Dept.Count();
        }

        public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            Model.Huang.PageList list = new Model.Huang.PageList();
            var obj = from p in entities.Dept
                      orderby p.DeptId
                      select new
                      {
                          DeptId = p.DeptId,
                          DeptName = p.DeptName,
                          CreateTime = p.CreateTime,
                          IsDelete = p. IsDelete,
                          Remake=p.Remake
                      };
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            int rows = entities.Dept.Count();
            list.PageCount = rows % pagesize == 0 ? rows / pagesize : rows / pagesize + 1;
            return list;
        }

        public static IQueryable GetById(int DeptId)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Dept
                      where p.DeptId == DeptId
                      select new
                      {
                          DeptId = p.DeptId,
                          DeptName = p.DeptName,
                          CreateTime = p.CreateTime,
                          Remake = p.Remake
                      };
            return obj;

        }

        public static int Edit(Dept de)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Dept where p.DeptId == de.DeptId select p).First();
            obj.DeptName = de.DeptName;
            obj.CreateTime = de.CreateTime;
            obj.Remake = de.Remake;
            return entity.SaveChanges();
        }

        public static int Del(int DeptId)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            var obj = (from p in entities.Dept where p.DeptId == DeptId select p).First();
            entities.Dept.Remove(obj);
            return entities.SaveChanges();
        }

        public static int Add(Dept de)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            
            entities.Dept.Add(de);
            return entities.SaveChanges();
        }

        







    }
}
