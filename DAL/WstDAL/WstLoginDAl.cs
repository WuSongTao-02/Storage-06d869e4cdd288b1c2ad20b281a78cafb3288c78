using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.WstDAL
{
    public class WstLoginDAl
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static int Login(string name, string pwd) {

            CangChuEntities1 entity = new CangChuEntities1();
            int count = (from p in entity.Admin where p.UserName == name && p.PassWord == pwd && p.IsDelete == 0 && p.RoleId == 1 || p.RoleId == 2 select p).Count();
            return count;
        }


        /// <summary>
        /// 查询登录的人信息
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>数据集合</returns>
        public static IQueryable GetUserName(string UserName) {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Admin where p.UserName == UserName select new {
                Id = p.Id,
                UserName=  p.UserName,
                PassWord= p.PassWord,
                phone=p.phone,
                Email= p.Email,
                RealName= p.RealName,
                RoleName=  p.Role.RoleName,
                DeptName=p.Dept.DeptName,
            };
            return obj;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin">对象</param>
        /// <returns>受影响行数</returns>
        public static int UpdatePwd(int id ,string pwd) {
            CangChuEntities1 entity = new CangChuEntities1();
            var count = (from p in entity.Admin where p.Id ==id select p).First();
            count.PassWord = pwd;
            return entity.SaveChanges();
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static int UpdataUser(Admin admin) {
            CangChuEntities1 entity = new CangChuEntities1();
            var count = (from p in entity.Admin where p.UserName == admin.UserName select p).First();
            count.phone = admin.phone;
            count.RealName = admin.RealName;
            count.Email = admin.Email;
            return entity.SaveChanges();
        }
    }
}
