using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ParserCSharp
{
    public class ExcelAdapter
    {
        private Excel.Workbook MyBook = null;
        private Excel.Application MyApp = null;
        private Excel.Worksheet MySheet = null;
        private int lastRow;

        public string Path { get; private set; }

        public bool IsOpen { get; private set; }

        public void Open()
        {
            if (IsOpen == true) return;
            try
            {
                MyApp = new Excel.Application();
                MyApp.Visible = false;
                MyBook = MyApp.Workbooks.Open(Path);
                MySheet = (Excel.Worksheet)MyBook.Sheets[1];
                lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                IsOpen = true;
            }
            catch (Exception e)
            {
                IsOpen = false;
                throw (e);

            }

        }
        public ExcelAdapter(string path)
        {
            this.Path = path;
            IsOpen = false;
        }

        public void write(string moduleTb,string fileTb,string methodTb,string lineTb,string node)
        {
            if (!IsOpen)
                Open();

            lastRow += 1;
            MySheet.Cells[lastRow, 1] = moduleTb;
            MySheet.Cells[lastRow, 2] = fileTb;
            MySheet.Cells[lastRow, 3] = methodTb;
            MySheet.Cells[lastRow, 4] = lineTb;
            MySheet.Cells[lastRow, 5] = node;

            MyBook.Save();
        }

        public void close()
        {
            if (IsOpen)
            {
                MyBook.Save();
                MyBook.Close();
                IsOpen = false;
            }           
        }

}
}
