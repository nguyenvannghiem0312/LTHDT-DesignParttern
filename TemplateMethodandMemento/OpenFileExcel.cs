using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TemplateMethodandMemento
{
    public class OpenFileExcel : OpenFileTemplateMethod
    {
        protected override bool ValidateFileName(string fileName)
        {
            if (!fileName.EndsWith(".xlsx") && !fileName.EndsWith(".xls"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected override void DoOpenFile(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;

            try {
                // Get the number of rows and columns in the used range
                int rows = usedRange.Rows.Count;
                int columns = usedRange.Columns.Count;

                // Create a new DataTable to store the data
                DataTable dataTable = new DataTable();

                // Add columns to the DataTable
                for (int i = 1; i <= columns; i++)
                {
                    dataTable.Columns.Add(worksheet.Cells[1, i].Value.ToString());
                }

                // Add rows to the DataTable
                for (int i = 2; i <= rows; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int j = 1; j <= columns; j++)
                    {
                        dataRow[j - 1] = worksheet.Cells[i, j].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Set the DataSource of the DataGridView to the DataTable
                Form1._Form1.dataGridView.DataSource = dataTable;

                // Close the workbook and release the resources
                workbook.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
