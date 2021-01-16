using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.ShuaiDAL
{
    public  class YiKuService
    {

        public static IQueryable Yikuchaxun()
        {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = from p in hh.GarageShift
                      orderby p.GarSId
                      select new {
                          AudiId=p.AudiId,
                          GarSType=p.GarSType,
                          GarSOrder=p.GarSOrder,
                          num=from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson=p.GarSPerson,
                          IsDelete=p.IsDelete,
                          CreateTime=p.CreateTime,
                      };

            return obj;

        }

        public static int GetRows1()
        {
            CangChuEntities1 hh = new CangChuEntities1();
            return hh.GarageShift.Count();
        }
       /// <summary>
       /// 分页
       /// </summary>
       /// <param name="PageIndex"></param>
       /// <param name="PageSize"></param>
       /// <returns></returns>
        public static ShuaiPageList YikuPageList(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where p.IsDelete == 0
                      orderby p.GarSId
                      select new
                      {
                          GarSId=p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        /// <summary>
        /// 所有条件查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="name"></param>
        /// <param name="sname"></param>
        /// <param name="sname2"></param>
        /// <returns></returns>
        public static ShuaiPageList YikuPageList2(int PageIndex, int PageSize, string name,DateTime sname,DateTime sname2)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where p.GarSType.Contains(name)&&p.CreateTime>=sname&&p.CreateTime<=sname2
                      orderby p.GarSId
                      select new
                      {
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        /// <summary>
        /// 按照时间区间查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="name"></param>
        /// <param name="sname"></param>
        /// <param name="sname2"></param>
        /// <returns></returns>
        public static ShuaiPageList YikuPageList3(int PageIndex, int PageSize, DateTime sname, DateTime sname2)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where  p.CreateTime >= sname && p.CreateTime <= sname2
                      orderby p.GarSId
                      select new
                      {
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        /// <summary>
        /// 按照类型查询
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ShuaiPageList YikuPageList1(int PageIndex, int PageSize,string name)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift

                      where p.GarSType.Contains(name)
                      orderby p.GarSId
                      select new
                      {
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }


        public static ShuaiPageList querydaishenhe(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where p.AudiId==1
                      orderby p.GarSId
                      select new
                      { 
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,   
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        public static ShuaiPageList Querytongguo(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where p.AudiId == 2
                      orderby p.GarSId
                      select new
                      {
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        public static ShuaiPageList Queryshibai(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.GarageShift
                      where p.AudiId == 3
                      orderby p.GarSId
                      select new
                      {
                          GarSId = p.GarSId,
                          AudiId = p.AudiId,
                          GarSType = p.GarSType,
                          GarSOrder = p.GarSOrder,
                          num = from jj in hh.GarageShiftStorage select jj.Num,
                          GarSPerson = p.GarSPerson,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
        

        public static int yikuedit(int id)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = hh.GarageShift.Where(p => p.GarSId == id).FirstOrDefault();
            if (obj != null)
            {

                obj.IsDelete = 1;

            }
            return hh.SaveChanges();
        }
    }


}
