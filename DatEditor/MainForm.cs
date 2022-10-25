﻿using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.WinForms.Controls;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DatEditor
{
    public partial class MainForm : SfForm
    {
        private FileStream DatFile;
        public MainForm()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            DFileChooser.ShowDialog();
        }

        private void DFileChooser_FileOk(object sender, CancelEventArgs e)
        {
            LFile.Text = DFileChooser.FileName;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int ctr = 0;
            DataTable dt = new DataTable();
            try
            {
                DatFile = new FileStream(DFileChooser.FileName, FileMode.Open, FileAccess.Read);
            }catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            using(StreamReader reader = new StreamReader(DatFile, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string currentLine = Regex.Replace(reader.ReadLine(), "[^\u0000-\u007F]", String.Empty);
                    string[] data = currentLine.Split('\u0014');
                    if(ctr == 0)
                    {
                        foreach(var col in data)
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

            SpreadsheetForm form = new SpreadsheetForm(dt, DFileChooser.SafeFileName);
            form.Show();
            

        }
    }
}
