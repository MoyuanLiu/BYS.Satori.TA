using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelUtils
{
    public class ExcelOptions
    {
        /// <summary>
        /// 加载指定路径下的Excel文件
        /// </summary>
        /// <param name="path">文件所在绝对路径</param>
        /// <returns>该位置下的workbook对象</returns>
        public static XSSFWorkbook LoadExcel(string path)
        {
            XSSFWorkbook xssfwb;
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                xssfwb = new XSSFWorkbook(file);
            }
            return xssfwb;
        }
        /// <summary>
        /// 获得一个workbook下的所有sheet
        /// </summary>
        /// <param name="xssfwb">workbook对象</param>
        /// <returns>该workbook对象sheet列表</returns>
        public List<XSSFSheet> GetAllSheets(XSSFWorkbook xssfwb)
        {
            List<XSSFSheet> sheets = new List<XSSFSheet>();
            for (int i = 0; i < xssfwb.NumberOfSheets; i++)
            {
                XSSFSheet sheet = (XSSFSheet)xssfwb.GetSheetAt(i);
                sheets.Add(sheet);
            }
            return sheets;
        }
        /// <summary>
        /// 从sheet列表中获取特定名字的sheet
        /// </summary>
        /// <param name="sheets">sheet列表</param>
        /// <param name="sheetname">要获取的sheet的名字</param>
        /// <returns>特定名字的sheet对象</returns>
        public static XSSFSheet GetSheetbyName(List<XSSFSheet> sheets, string sheetname)
        {
            XSSFSheet sheet = new XSSFSheet();
            for (int i = 0; i < sheets.Count; i++)
            {
                if (sheets[i].SheetName == sheetname)
                {
                    sheet = sheets[i];
                }
            }
            return sheet;
        }
        /// <summary>
        /// 将excel文件保存到特定的路径下
        /// </summary>
        /// <param name="xssfwb">要保存的excel文件</param>
        /// <param name="target">目标路径</param>
        public static void SaveExcel(XSSFWorkbook xssfwb, string target)
        {
            FileStream sw = File.Create(target);
            xssfwb.Write(sw);
            sw.Close();
        }

    }
}
