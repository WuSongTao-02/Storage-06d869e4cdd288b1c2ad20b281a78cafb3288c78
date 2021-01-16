using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Huang
{
   public  class PageList
    {
        public int PageCount { get; set; }

        public IQueryable DataList { get; set; }
    }
}
