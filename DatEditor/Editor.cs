using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatEditor
{
    internal class Editor
    {
        private FileStream DatFile;

        public Editor(string file)
        {
            string fileExt = Path.GetExtension(file);
            switch (fileExt)
            {
                case ".xlsx":
                case ".xls":
                case ".csv":
                case ".xlsm":
                            {
                                Application.Run(new SpreadsheetForm(file));
                                break;
                            }
                default:
                        {
                            DatFile = new FileStream(file, FileMode.Open, FileAccess.Read);
                            EditDatFile(file);
                            break;
                        }
                    
            }
        }
        private void EditDatFile(string fileName)
        {
            int ctr = 0;
            DataTable dt = new DataTable();
            using (StreamReader reader = new StreamReader(DatFile, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    string currentLineFormatted = Regex.Replace(currentLine, "[^\u0000-\u007F]", String.Empty);
                    string[] data = currentLineFormatted.Split('\u0014');
                    if (ctr == 0)
                    {
                        foreach (var col in data)
                        {
                            dt.Columns.Add(col);
                        }
                    }
                    else
                    {
                        dt.Rows.Add(data);
                    }
                    ctr++;
                }
            }

            Application.Run(new SpreadsheetForm(dt, Path.GetFileNameWithoutExtension(fileName)));
        }
    }
}
