#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatEditor
{
    public partial class SpreadsheetForm : RibbonForm
    {
      

        public SpreadsheetForm(DataTable dt, String fileName)
        {
            InitializeComponent(dt, fileName);
        }
    }
}
