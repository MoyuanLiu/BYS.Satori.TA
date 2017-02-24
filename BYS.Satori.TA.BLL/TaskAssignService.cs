using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.Satori.TA.BLL
{
    public class TaskAssignService
    {
        public static void assign(DataTable dt,List<string> names)
        {
            int total = dt.Rows.Count;
            int num = names.Count;
            int pagesize = total / num;
            int pages;
            if (total % num > 0)
            {
                pages = num + 1;
            }
            else
            {
                pages = num;
            }

        }
    }
}
