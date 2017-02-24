using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelUtils
{
    public static class ConvertSheetwithDT
    {
        /// <summary>
        /// 将特定sheet转换为DataTable
        /// </summary>
        /// <param name="sheet">要转换的sheet</param>
        /// <returns>转换之后的DaraTable</returns>
        public static DataTable SheetToDataTable(XSSFSheet sheet)
        {
            DataTable dt = new DataTable();

            for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
            {
                if (dt.Columns.Count < sheet.GetRow(i).Cells.Count)
                {
                    for (int j = 0; j < sheet.GetRow(i).Cells.Count; j++)
                    {
                        dt.Columns.Add("", typeof(string));
                    }
                }
            }
            for (int j = sheet.FirstRowNum; j <= sheet.LastRowNum; j++)
            {
                XSSFRow row = (XSSFRow)sheet.GetRow(j);
                DataRow dr = dt.Rows.Add();
                for (int k = 0; k < row.Cells.Count; k++)
                {

                    XSSFCell cell = (XSSFCell)row.GetCell(k);

                    if (cell != null)
                    {
                        switch (cell.CellType)
                        {
                            case CellType.Numeric:
                                dr[k] = cell.NumericCellValue;
                                break;
                            case CellType.String:
                                dr[k] = cell.StringCellValue;
                                break;
                            case CellType.Blank:
                                dr[k] = "";
                                break;
                            case CellType.Boolean:
                                dr[k] = cell.BooleanCellValue;
                                break;
                        }
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// DataTable转换成Excel文件
        /// </summary>
        /// <param name="dt">要转换的DataTable</param>
        /// <returns>生成的Excel文件</returns>
        public static XSSFWorkbook DataTabletoExcel(DataTable dt)
        {
            XSSFWorkbook xssfwb = new XSSFWorkbook();
            XSSFSheet sheet = (XSSFSheet)xssfwb.CreateSheet();
            sheet.CreateRow(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                sheet.CreateRow(i);
                XSSFRow row = (XSSFRow)sheet.GetRow(i);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    XSSFCell cell = (XSSFCell)row.CreateCell(j);
                    cell.SetCellValue(dr[j].ToString());
                }
            }
            return xssfwb;
        }
    }
}
