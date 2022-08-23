﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Demo_Form {
    public partial class mainForm : Form {
        private FileStream _file = null;
        public mainForm() {
            InitializeComponent();
        }

        private void recetarioDataSetBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void mainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'recetarioDataSet.Consulta_Receta' table. You can move, or remove it, as needed.
            //this.consulta_RecetaTableAdapter.Fill(this.recetarioDataSet.Consulta_Receta);
            // TODO: This line of code loads data into the 'recetarioDataSet.Receta' table. You can move, or remove it, as needed.
            //this.recetaTableAdapter.Fill(this.recetarioDataSet.Receta);
            // TODO: This line of code loads data into the 'recetarioDataSet.Fotos' table. You can move, or remove it, as needed.


        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.sttsBar = new System.Windows.Forms.StatusStrip();
            this.lblPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripMenu = new System.Windows.Forms.ToolStrip();
            this.btnSaveCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gridCSV = new System.Windows.Forms.DataGridView();
            this.sttsBar.SuspendLayout();
            this.stripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdCSV
            // 
            this.ofdCSV.FileName = "ofdCSV";
            this.ofdCSV.Filter = "\"csv files (*.csv)|*.csv|All files (*.*)|*.*\"";
            // 
            // sttsBar
            // 
            this.sttsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPath});
            this.sttsBar.Location = new System.Drawing.Point(0, 592);
            this.sttsBar.Name = "sttsBar";
            this.sttsBar.Size = new System.Drawing.Size(868, 22);
            this.sttsBar.TabIndex = 0;
            this.sttsBar.Text = "statusStrip1";
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(57, 17);
            this.lblPath.Text = "Path: . . .";
            // 
            // stripMenu
            // 
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnSaveCSV});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(868, 25);
            this.stripMenu.TabIndex = 1;
            this.stripMenu.Text = "toolStrip1";
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCSV.Image")));
            this.btnSaveCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(59, 22);
            this.btnSaveCSV.Text = "Save CSV";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "Load CSV";
            this.toolStripButton2.ToolTipText = "btnSaveCSV";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // gridCSV
            // 
            this.gridCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCSV.Location = new System.Drawing.Point(0, 25);
            this.gridCSV.Name = "gridCSV";
            this.gridCSV.Size = new System.Drawing.Size(868, 567);
            this.gridCSV.TabIndex = 2;
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(868, 614);
            this.Controls.Add(this.gridCSV);
            this.Controls.Add(this.stripMenu);
            this.Controls.Add(this.sttsBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sttsBar.ResumeLayout(false);
            this.sttsBar.PerformLayout();
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.OpenFileDialog ofdCSV;
        private void toolStripButton2_Click(object sender, EventArgs e) {
            if (this.ofdCSV.ShowDialog() == DialogResult.OK) {
                this._file = new FileStream(this.ofdCSV.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                this.lblPath.Text  = "Path: " + this._file.Name;

                this.gridCSV.DataSource = (new file_handler().file_to_table(this._file));
            }
        }
    }
}
