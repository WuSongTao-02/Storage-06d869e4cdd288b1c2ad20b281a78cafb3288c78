using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL.WstBLL
{
    public class WstLoginBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>受影响行数</returns>
        public static int Login(string name, string pwd)
        {
            return DAL.WstDAL.WstLoginDAl.Login(name, pwd);
        }

        /// <summary>
        /// 查询登录的人信息
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>数据集合</returns>
        public static IQueryable GetUserName(string UserName)
        {
            return DAL.WstDAL.WstLoginDAl.GetUserName(UserName);
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="admin">对象</param>
        /// <returns>受影响行数</returns>
        public static int UpdatePwd(int id, string pwd)
        {
           
            return DAL.WstDAL.WstLoginDAl.UpdatePwd(id,pwd);
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static int UpdataUser(Admin admin)
        {
            return DAL.WstDAL.WstLoginDAl.UpdataUser(admin);
        }


        }
}
