using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlUtils
{
    public static class XmlOptions
    {
        public static XDocument LoadXml(string path)
        {
            XDocument document = XDocument.Load(path);
            return document;
        }
        public static XNode CreateElement(string name)
        {
            XElement node = new XElement(name);
            return node;
        }
        public static XDocument AddElement(XDocument document, XElement node)
        {
            XElement rootElement = document.Root;
            rootElement.Add(node);
            return document;
        }
        public static List<XElement> GetAllElements(XDocument document)
        {
            XElement rootElement = document.Root;
            List<XElement> nodes = new List<XElement>();
            foreach (var item in rootElement.Elements())
            {
                nodes.Add(item);
            }
            return nodes;
        }
        public static XElement GetElementbyName(XDocument document,string name)
        {
            XElement rootElement = document.Root;
            XElement element = rootElement.Element(name);
            return element;
        }
        public static XDocument DeleteElement(XDocument document,string name)
        {
            XElement element = GetElementbyName(document, name);
            if (element!=null)
            {
                element.Remove();
            }
            return document;
        }
    }
}
