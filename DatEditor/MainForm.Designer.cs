namespace DatEditor
{
    partial class MainForm
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
            this.DFileChooser = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpenFile = new Syncfusion.WinForms.Controls.SfButton();
            this.LFile = new System.Windows.Forms.Label();
            this.BtnEdit = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBlank = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DFileChooser
            // 
            this.DFileChooser.DefaultExt = "dat";
            this.DFileChooser.Filter = "Concordance (*.DAT)|*.DAT|TXT (*.TXT)|*.TXT";
            this.DFileChooser.FileOk += new System.ComponentModel.CancelEventHandler(this.DFileChooser_FileOk);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.AccessibleName = "Button";
            this.BtnOpenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.BtnOpenFile.Location = new System.Drawing.Point(3, 3);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(166, 28);
            this.BtnOpenFile.TabIndex = 1;
            this.BtnOpenFile.Text = "Select DAT File";
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // LFile
            // 
            this.LFile.Location = new System.Drawing.Point(-1, 11);
            this.LFile.Name = "LFile";
            this.LFile.Size = new System.Drawing.Size(348, 71);
            this.LFile.TabIndex = 2;
            this.LFile.Text = "No file selected";
            this.LFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEdit
            // 
            this.BtnEdit.AccessibleName = "Button";
            this.BtnEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Location = new System.Drawing.Point(175, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(166, 28);
            this.BtnEdit.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnEdit.Style.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBlank);
            this.panel1.Controls.Add(this.BtnOpenFile);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 69);
            this.panel1.TabIndex = 4;
            // 
            // BtnBlank
            // 
            this.BtnBlank.AccessibleName = "Button";
            this.BtnBlank.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.BtnBlank.Location = new System.Drawing.Point(3, 37);
            this.BtnBlank.Name = "BtnBlank";
            this.BtnBlank.Size = new System.Drawing.Size(338, 28);
            this.BtnBlank.Style.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnBlank.TabIndex = 4;
            this.BtnBlank.Text = "Open Blank Editor";
            this.BtnBlank.UseVisualStyleBackColor = false;
            this.BtnBlank.Click += new System.EventHandler(this.BtnBlank_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 171);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(589, 341);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "DatEditor v1.0.1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DFileChooser;
        private Syncfusion.WinForms.Controls.SfButton BtnOpenFile;
        private System.Windows.Forms.Label LFile;
        private Syncfusion.WinForms.Controls.SfButton BtnEdit;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton BtnBlank;
    }
}