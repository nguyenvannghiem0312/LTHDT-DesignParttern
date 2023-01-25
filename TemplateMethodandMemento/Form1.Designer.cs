
namespace TemplateMethodandMemento
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDL = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDL = new System.Windows.Forms.SaveFileDialog();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 21);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(776, 417);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.Visible = false;
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(12, 21);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(776, 417);
            this.dgvExcel.TabIndex = 1;
            this.dgvExcel.Visible = false;
            this.dgvExcel.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcel_CellValidated);
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(867, 24);
            this.menuFile.TabIndex = 2;
            this.menuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItemNewFile,
            this.excelToolStripMenuItemNewFile});
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "&New File";
            // 
            // textToolStripMenuItemNewFile
            // 
            this.textToolStripMenuItemNewFile.Name = "textToolStripMenuItemNewFile";
            this.textToolStripMenuItemNewFile.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItemNewFile.Text = "&Text";
            this.textToolStripMenuItemNewFile.Click += new System.EventHandler(this.textToolStripMenuItemNewFile_Click);
            // 
            // excelToolStripMenuItemNewFile
            // 
            this.excelToolStripMenuItemNewFile.Name = "excelToolStripMenuItemNewFile";
            this.excelToolStripMenuItemNewFile.Size = new System.Drawing.Size(180, 22);
            this.excelToolStripMenuItemNewFile.Text = "&Excel";
            this.excelToolStripMenuItemNewFile.Click += new System.EventHandler(this.excelToolStripMenuItemNewFile_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItemOpenFile,
            this.excelToolStripMenuItemOpenFile});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "&Open File";
            // 
            // textToolStripMenuItemOpenFile
            // 
            this.textToolStripMenuItemOpenFile.Name = "textToolStripMenuItemOpenFile";
            this.textToolStripMenuItemOpenFile.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItemOpenFile.Text = "&Text";
            this.textToolStripMenuItemOpenFile.Click += new System.EventHandler(this.textToolStripMenuItemOpenFile_Click);
            // 
            // excelToolStripMenuItemOpenFile
            // 
            this.excelToolStripMenuItemOpenFile.Name = "excelToolStripMenuItemOpenFile";
            this.excelToolStripMenuItemOpenFile.Size = new System.Drawing.Size(180, 22);
            this.excelToolStripMenuItemOpenFile.Text = "&Excel";
            this.excelToolStripMenuItemOpenFile.Click += new System.EventHandler(this.excelToolStripMenuItemOpenFile_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItemSave,
            this.excelToolStripMenuItemSave});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "&Save as";
            // 
            // textToolStripMenuItemSave
            // 
            this.textToolStripMenuItemSave.Name = "textToolStripMenuItemSave";
            this.textToolStripMenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItemSave.Text = "&Text";
            this.textToolStripMenuItemSave.Click += new System.EventHandler(this.textToolStripMenuItemSave_Click);
            // 
            // excelToolStripMenuItemSave
            // 
            this.excelToolStripMenuItemSave.Name = "excelToolStripMenuItemSave";
            this.excelToolStripMenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.excelToolStripMenuItemSave.Text = "&Excel";
            this.excelToolStripMenuItemSave.Click += new System.EventHandler(this.excelToolStripMenuItemSave_Click);
            // 
            // openFileDL
            // 
            this.openFileDL.FileName = "openFileDialog1";
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(796, 225);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(59, 24);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItemOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDL;
        private System.Windows.Forms.SaveFileDialog saveFileDL;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItemSave;
        private System.Windows.Forms.Button btnUndo;
    }
}

