using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ShuaiPageList
    {
        public int PageCoun { get; set; }
        public IQueryable DataList { get; set; }
    }
}
