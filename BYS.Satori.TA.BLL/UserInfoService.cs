using BYS.Satori.TA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlUtils;

namespace BYS.Satori.TA.BLL
{
    public class UserInfoService
    {
        public static void AddUser(string name,string xmlpath)
        {
            UserInfo user = new UserInfo();
            user.Name = name;
            XDocument doc = XmlOptions.LoadXml(xmlpath);
            XNode node = XmlOptions.CreateElement(name);
        }
    }
}
