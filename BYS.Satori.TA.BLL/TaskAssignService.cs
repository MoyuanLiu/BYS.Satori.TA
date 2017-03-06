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
        public static DataTable assign(DataTable dt,List<string> names)
        {
            int total = dt.Rows.Count;
            int num = names.Count;
            int pagesize = total / num;
            int currentpage = 0;
            int currentindex = 0;
            int pages;
            if (total % num > 0)
            {
                pages = num + 1;
            }
            else
            {
                pages = num;
            }
            dt.Columns.Add();
            while (currentindex<= total)
            {
                for (int i = 0;i<pagesize;i++)
                {
                    dt.Rows[currentindex][dt.Columns.Count] = names[currentpage];
                    currentindex++;
                }
                currentpage++;
            }
            return dt;
        }
    }
}
