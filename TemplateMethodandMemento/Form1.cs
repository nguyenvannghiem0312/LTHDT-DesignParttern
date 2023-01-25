using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TemplateMethodandMemento
{
    public partial class Form1 : Form
    {
        private bool isUndo = false;
        private bool isText = false, isExcel = false;

        static Originator originator = new Originator(null);
        Caretaker caretaker = new Caretaker(originator);

        public static Form1 _Form1;
        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }
        /// <summary>
        /// return control OpenFileDiaLog of Form
        /// </summary>
        public OpenFileDialog openFileDialog
        {
            get { return openFileDL; }
        }
        /// <summary>
        /// set string into content of RichTextBox 
        /// </summary>
        public string richTextBox
        {
            set { rtbText.Text = value; }
        }
        /// <summary>
        /// return DialogReSult.OK
        /// </summary>
        public DialogResult dialogResultOK
        {
            get { return DialogResult.OK; }
        }
        /// <summary>
        /// return control DataGridView of Form
        /// </summary>
        public DataGridView dataGridView
        {
            get { return dgvExcel; }
        }
        /// <summary>
        /// return control button Undo 
        /// </summary>
        public Button buttonUndo
        {
            get { return btnUndo; }
        }
        /// <summary>
        /// show MessageBox Error
        /// </summary>
        public void messageBox()
        {
            MessageBox.Show("Error File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SetState(bool Text)
        {
            if(Text == true)
            {
                isText = true;
                isExcel = false;
                rtbText.Visible = true;
                dgvExcel.Visible = false;
            }
            else
            {
                isText = false;
                isExcel = true;
                rtbText.Visible = false;
                dgvExcel.Visible = true;
            }
        }
        /// <summary>
        /// Open the text file has existed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            SetState(true);
            caretaker.ClearUnnecessaryHistory();
            OpenFileText openFileText = new OpenFileText();
            openFileText.OpenFile();
            originator.DoSomeThing(rtbText.Text);
            caretaker.BackUp();
        }
        /// <summary>
        /// Open the excel file has existed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            SetState(false);
            caretaker.ClearUnnecessaryHistory();
            OpenFileExcel openFileExcel = new OpenFileExcel();
            openFileExcel.OpenFile();
            originator.DoSomeThing(GetDataTableFromDGV(dgvExcel));
            caretaker.BackUp();
        }
        /// <summary>
        /// Create and open new Text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textToolStripMenuItemNewFile_Click(object sender, EventArgs e)
        {
            SetState(true);
            caretaker.ClearUnnecessaryHistory();
            rtbText.Clear();
            originator.DoSomeThing(rtbText.Text);
            caretaker.BackUp();
        }
        /// <summary>
        /// Create and open new Excel file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripMenuItemNewFile_Click(object sender, EventArgs e)
        {
            SetState(false);
            caretaker.ClearUnnecessaryHistory();
            dgvExcel.ColumnCount = 7;
            dgvExcel.RowCount = 20;
            originator.DoSomeThing(GetDataTableFromDGV(dgvExcel));
            caretaker.BackUp();
        }
        /// <summary>
        /// Save Text File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDL.Filter = "|*.txt";
            saveFileDL.RestoreDirectory = true;
            if(saveFileDL.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDL.FileName);
                writer.WriteLine(rtbText.Text);
                writer.Close();
            }
        }
        /// <summary>
        /// Save Excel File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excelToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDL.Filter = "|*.xlsx";
            saveFileDL.RestoreDirectory = true;
            if (saveFileDL.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

                // Write the data from the DataGridView to the worksheet
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = dataGridView[j, i].Value;
                    }
                }
                workbook.SaveAs(saveFileDL.FileName);
                workbook.Close();
                excelApp.Quit();
            }
            
        }
        /// <summary>
        /// Save the record when the text file changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            if (isUndo == false && isText == true)
            {
                caretaker.BackUp();
                originator.DoSomeThing(rtbText.Text);
            }
            else
            {
                isUndo = false;
            }
        }
        /// <summary>
        /// Undo file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {
            object objUndo = caretaker.Undo();
            if (isText == true && objUndo != null)
            {
                rtbText.Text = (string)objUndo;
                rtbText.SelectionStart = rtbText.Text.Length;
                isUndo = true;
            }
            if(isExcel == true && objUndo != null)
            {
                DataTableToDataGrid(dgvExcel, (DataTable)caretaker.Undo());
                isUndo = true;
            }
        }
        /// <summary>
        /// Get DataTable data from DataGridView data
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.Name);
            }

            object[] cellValues = new object[dgv.Columns.Count];

            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }
        /// <summary>
        /// Get DataGridView data from DataTable data
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="datatable"></param>
        private void DataTableToDataGrid(DataGridView dgv, DataTable datatable)
        {
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                for (int j = 0; j < datatable.Columns.Count; j++)
                {
                    dgv.Rows[i].Cells[j].Value = datatable.Rows[i][j].ToString();
                }
            }
        }
        /// <summary>
        /// Save the record when the excel file changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExcel_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            if (dgv.Rows[r].Cells[c].Value != null)
            {
                string dgvResult = dgv.Rows[r].Cells[c].Value.ToString();
                string dtResult = ((DataTable)caretaker.GetCurrentState()).Rows[r][c].ToString();
                if (dgvResult != dtResult)
                {
                    originator.DoSomeThing(GetDataTableFromDGV(dgvExcel));
                    caretaker.BackUp();
                }
            }
        }
    }
}
