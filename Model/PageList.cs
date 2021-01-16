using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PageList
    {
        //总页数
        public int PageCount { get; set; }
        public int Pagesize { get; set; }
        public int PageIndex { get; set; }
        //分页数据
        public IQueryable Datalist { get; set; }
        public IQueryable DataList { get; set; }
    }
}
