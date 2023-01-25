using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TemplateMethodandMemento
{
    /// <summary>
    /// Template method of OpenFile function
    /// </summary>
    public abstract class OpenFileTemplateMethod
    {
        /// <summary>
        /// The skeleton of OpenFile function
        /// </summary>
        public void OpenFile()
        {
            string fileName = GetFileName();
            if (ValidateFileName(fileName))
            {
                DoOpenFile(fileName);
            }
            else
            {
                DisplayErrorMessage();
            }
        }
        /// <summary>
        /// Returns the name of the file to be opened
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            Form1._Form1.openFileDialog.Title = "Open File";
            if (Form1._Form1.openFileDialog.ShowDialog() == Form1._Form1.dialogResultOK)
            {
                return Form1._Form1.openFileDialog.FileName;
            }
            return "";
        }
        /// <summary>
        /// Check the validity of the file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected abstract bool ValidateFileName(string fileName);
        /// <summary>
        /// Open and Show file
        /// </summary>
        /// <param name="fileName"></param>
        protected abstract void DoOpenFile(string fileName);
        /// <summary>
        /// Show error when can not open file
        /// </summary>
        public void DisplayErrorMessage()
        {
            Form1._Form1.messageBox();
        }
    }
}
