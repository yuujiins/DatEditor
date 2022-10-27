#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Syncfusion.Windows.Forms.CellGrid;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Spreadsheet.Helpers;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.Win32API;
using System.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms.Tools;
using DatEditor.Properties;
using System.ComponentModel;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.XlsIO;

namespace DatEditor
{
    partial class SpreadsheetForm
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

        private string fileName;
        private SaveFileDialog saveFileDialog;
        #region Windows Form Designer generated code

        private Spreadsheet spreadsheet;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(DataTable dt, String fileName)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            this.fileName = fileName;
            this.Text = fileName;
            this.Icon = Resources.pencil_white;
            
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetForm));
            #region Spreadsheet

            spreadsheet = new Spreadsheet();
            SpreadsheetRibbon ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            ToolStripTabItem loadFileItem = new ToolStripTabItem();
            ToolStripButton exportButton = new ToolStripButton();
            ToolStripEx tx = new ToolStripEx();
            exportButton.Text = "Export/Save";
            exportButton.Image = Resources.export_512;
            exportButton.Click += ExportDat;
            tx.Text = "Exporting";
            loadFileItem.Panel.Controls.AddRange(new Control[] {
                tx
            });
            tx.Items.AddRange(new ToolStripItem[]
            {
                exportButton
            });
            loadFileItem.Text = "EXPORT";
            ribbon.Header.AddMainItem(loadFileItem);
            this.DataBindings.Add("Text", this.spreadsheet, "FileName");
            
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            spreadsheet.DefaultColumnCount = 16384;
            spreadsheet.DefaultRowCount = 1048576;
            spreadsheet.AllowFiltering = true;
            spreadsheet.Create(1);
            spreadsheet.FileName = fileName;
            spreadsheet.ActiveSheet.ImportDataTable(dt, true, 1, 1, true);
            spreadsheet.ActiveGrid.InvalidateCells();
            

            
            this.Controls.Add(spreadsheet);
            this.Controls.Add(ribbon);
            
            #endregion
        }

        private void InitializeComponent(string filename)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetForm));
            #region Spreadsheet

            spreadsheet = new Spreadsheet();
            SpreadsheetRibbon ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            ToolStripTabItem loadFileItem = new ToolStripTabItem();
            ToolStripButton exportButton = new ToolStripButton();
            ToolStripEx tx = new ToolStripEx();
            exportButton.Text = "Export/Save";
            exportButton.Image = Resources.export_512;
            exportButton.Click += ExportDat;
            tx.Text = "Exporting";
            loadFileItem.Panel.Controls.AddRange(new Control[] {
                tx
            });
            tx.Items.AddRange(new ToolStripItem[]
            {
                exportButton
            });
            loadFileItem.Text = "EXPORT";
            ribbon.Header.AddMainItem(loadFileItem);
            this.DataBindings.Add("Text", this.spreadsheet, "FileName");
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            spreadsheet.DefaultColumnCount = 16384;
            spreadsheet.DefaultRowCount = 1048576;
            spreadsheet.AllowFiltering = true;
            spreadsheet.Open(filename);


            this.Controls.Add(spreadsheet);
            this.Controls.Add(ribbon);

            this.Icon = Resources.pencil_white;
            #endregion
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetForm));
            #region Spreadsheet

            spreadsheet = new Spreadsheet();
            SpreadsheetRibbon ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            ToolStripTabItem loadFileItem = new ToolStripTabItem();
            ToolStripButton exportButton = new ToolStripButton();
            ToolStripEx tx = new ToolStripEx();
            exportButton.Text = "Export/Save";
            exportButton.Image = Resources.export_512;
            exportButton.Click += ExportDat;
            tx.Text = "Exporting";
            loadFileItem.Panel.Controls.AddRange(new Control[] {
                tx
            });
            tx.Items.AddRange(new ToolStripItem[]
            {
                exportButton
            });
            loadFileItem.Text = "EXPORT";
            ribbon.Header.AddMainItem(loadFileItem);
            this.DataBindings.Add("Text", this.spreadsheet, "FileName");
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            spreadsheet.DefaultColumnCount = 16384;
            spreadsheet.DefaultRowCount = 1048576;
            spreadsheet.AllowFiltering = true;


            this.Controls.Add(spreadsheet);
            this.Controls.Add(ribbon);

            this.Icon = Resources.pencil_white;
            #endregion
        }

        void spreadsheet_WorkbookLoaded(object sender, WorkbookLoadedEventArgs args)
        {
            IRange filterRange = spreadsheet.Workbook.ActiveSheet.UsedRange;
            spreadsheet.Workbook.ActiveSheet.AutoFilters.FilterRange = filterRange;
        }

        private void ExportDat(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.dat|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = fileName;
            saveFileDialog.FileOk += SaveFile_OK;
            saveFileDialog.ShowDialog();
        }
        private void SaveFile_OK(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DataTable dt = spreadsheet.Workbook.Worksheets[0].ExportDataTable(spreadsheet.Workbook.Worksheets[0].UsedRange, Syncfusion.XlsIO.ExcelExportDataTableOptions.ColumnNames);
            StreamWriter file = new StreamWriter(saveFileDialog.OpenFile());

            string line = "";
            for(int i = 0; i < dt.Rows.Count + 1; i++)
            {
                if (i == 0)
                {
                    string tempLine = "";
                    int innerctr = 0;
                    foreach (DataColumn dataColumn in dt.Columns)
                    {

                        string buff = "\u00FE" + dataColumn.ColumnName + "\u00FE";
                        if (innerctr < dt.Columns.Count - 1)
                        {
                            buff += "\u0014";
                        }
                        innerctr++;
                        tempLine += buff;
                    }
                    line = tempLine;
                    file.WriteLine(line);
                }
                else
                {
                    string tempLine = "";
                    int innerctr = 0;
                    foreach (DataColumn dataColumn in dt.Columns)
                    {
                        string buff = "\u00FE" + dt.Rows[i-1][dataColumn.ColumnName] + "\u00FE";
                        if (innerctr < dt.Columns.Count - 1)
                        {
                            buff += "\u0014";
                        }
                        innerctr++;
                        tempLine += buff;
                    }
                    line = tempLine;
                    if (1 < dt.Rows.Count - 1)
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        file.Write(line);
                    }
                }
            }
            file.Close();
            
        }

        /// <summary>
        /// Provide support for Excel like closing operation when press the close button.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            this.spreadsheet.Commands.FileClose.Execute(null);
            if (Form.ActiveForm != null)
                e.Cancel = true;
            base.OnClosing(e);
        }
        #endregion
    }
}

