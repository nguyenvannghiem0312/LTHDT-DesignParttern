using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TemplateMethodandMemento
{
    public class OpenFileText : OpenFileTemplateMethod
    {
        protected override bool ValidateFileName(string fileName)
        {
            if (!fileName.EndsWith(".txt"))
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
            Form1._Form1.richTextBox = File.ReadAllText(fileName);
        }
    }
}
