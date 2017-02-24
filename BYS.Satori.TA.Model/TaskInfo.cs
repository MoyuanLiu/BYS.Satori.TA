using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.Satori.TA.Model
{
    public class TaskInfo
    {
        public TaskInfo(string loadpath,string sheetname,string savepath,List<string> usernames)
        {
            LoadPath = loadpath;
            SheetName = sheetname;
            SavePath = savepath;
            UserNames = usernames;
        }
        public string LoadPath { get; set; }
        public string SheetName { get; set; }
        public string SavePath { get; set; }
        public List<string> UserNames { get; set; }
    }
}
