
namespace Szakdolgozat
{
    partial class Kiszallitas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiszallitas));
            this.KomissioGRPBX = new System.Windows.Forms.GroupBox();
            this.FelvetelBTN = new System.Windows.Forms.Button();
            this.AdatokDGV = new System.Windows.Forms.DataGridView();
            this.vevoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darabszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komissiozasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DarabszamTXB = new System.Windows.Forms.TextBox();
            this.CikkszamRTB = new System.Windows.Forms.RichTextBox();
            this.DarabszamRTB = new System.Windows.Forms.RichTextBox();
            this.VevoRTB = new System.Windows.Forms.RichTextBox();
            this.CikkszamCBBX = new System.Windows.Forms.ComboBox();
            this.VevoCBBX = new System.Windows.Forms.ComboBox();
            this.MenuGRPBX = new System.Windows.Forms.GroupBox();
            this.KomissiozasBTN = new System.Windows.Forms.Button();
            this.SzallitoBTN = new System.Windows.Forms.Button();
            this.KomissioListaBTN = new System.Windows.Forms.Button();
            this.printKomissiozas = new System.Drawing.Printing.PrintDocument();
            this.printPreviewKomissiozas = new System.Windows.Forms.PrintPreviewDialog();
            this.printSzallito = new System.Drawing.Printing.PrintDocument();
            this.printPreviewSzallito = new System.Windows.Forms.PrintPreviewDialog();
            this.KomissioGRPBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdatokDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komissiozasBindingSource)).BeginInit();
            this.MenuGRPBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // KomissioGRPBX
            // 
            this.KomissioGRPBX.Controls.Add(this.FelvetelBTN);
            this.KomissioGRPBX.Controls.Add(this.AdatokDGV);
            this.KomissioGRPBX.Controls.Add(this.DarabszamTXB);
            this.KomissioGRPBX.Controls.Add(this.CikkszamRTB);
            this.KomissioGRPBX.Controls.Add(this.DarabszamRTB);
            this.KomissioGRPBX.Controls.Add(this.VevoRTB);
            this.KomissioGRPBX.Controls.Add(this.CikkszamCBBX);
            this.KomissioGRPBX.Controls.Add(this.VevoCBBX);
            this.KomissioGRPBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KomissioGRPBX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KomissioGRPBX.ForeColor = System.Drawing.Color.White;
            this.KomissioGRPBX.Location = new System.Drawing.Point(0, 174);
            this.KomissioGRPBX.Name = "KomissioGRPBX";
            this.KomissioGRPBX.Size = new System.Drawing.Size(1155, 460);
            this.KomissioGRPBX.TabIndex = 7;
            this.KomissioGRPBX.TabStop = false;
            // 
            // FelvetelBTN
            // 
            this.FelvetelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FelvetelBTN.Location = new System.Drawing.Point(836, 74);
            this.FelvetelBTN.Name = "FelvetelBTN";
            this.FelvetelBTN.Size = new System.Drawing.Size(158, 40);
            this.FelvetelBTN.TabIndex = 13;
            this.FelvetelBTN.Text = "Felvétel";
            this.FelvetelBTN.UseVisualStyleBackColor = true;
            this.FelvetelBTN.Click += new System.EventHandler(this.FelvetelBTN_Click);
            // 
            // AdatokDGV
            // 
            this.AdatokDGV.AllowUserToAddRows = false;
            this.AdatokDGV.AllowUserToDeleteRows = false;
            this.AdatokDGV.AutoGenerateColumns = false;
            this.AdatokDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.AdatokDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdatokDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdatokDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vevoDataGridViewTextBoxColumn,
            this.cikkszamDataGridViewTextBoxColumn,
            this.darabszamDataGridViewTextBoxColumn});
            this.AdatokDGV.DataSource = this.komissiozasBindingSource;
            this.AdatokDGV.GridColor = System.Drawing.Color.Black;
            this.AdatokDGV.Location = new System.Drawing.Point(23, 192);
            this.AdatokDGV.Name = "AdatokDGV";
            this.AdatokDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdatokDGV.RowHeadersWidth = 51;
            this.AdatokDGV.RowTemplate.Height = 24;
            this.AdatokDGV.Size = new System.Drawing.Size(752, 215);
            this.AdatokDGV.TabIndex = 12;
            this.AdatokDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdatokDGV_SorTorlese);
            // 
            // vevoDataGridViewTextBoxColumn
            // 
            this.vevoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vevoDataGridViewTextBoxColumn.DataPropertyName = "vevo";
            this.vevoDataGridViewTextBoxColumn.HeaderText = "Vevő";
            this.vevoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vevoDataGridViewTextBoxColumn.Name = "vevoDataGridViewTextBoxColumn";
            this.vevoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vevoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vevoDataGridViewTextBoxColumn.Width = 200;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkszamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cikkszamDataGridViewTextBoxColumn.Width = 150;
            // 
            // darabszamDataGridViewTextBoxColumn
            // 
            this.darabszamDataGridViewTextBoxColumn.DataPropertyName = "darabszam";
            this.darabszamDataGridViewTextBoxColumn.HeaderText = "Darabszam";
            this.darabszamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.darabszamDataGridViewTextBoxColumn.Name = "darabszamDataGridViewTextBoxColumn";
            this.darabszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.darabszamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.darabszamDataGridViewTextBoxColumn.Width = 150;
            // 
            // komissiozasBindingSource
            // 
            this.komissiozasBindingSource.DataSource = typeof(Szakdolgozat.Komissiozas);
            // 
            // DarabszamTXB
            // 
            this.DarabszamTXB.Location = new System.Drawing.Point(567, 73);
            this.DarabszamTXB.MaxLength = 11;
            this.DarabszamTXB.Name = "DarabszamTXB";
            this.DarabszamTXB.Size = new System.Drawing.Size(223, 32);
            this.DarabszamTXB.TabIndex = 9;
            this.DarabszamTXB.TextChanged += new System.EventHandler(this.SzamEllenorzes);
            // 
            // CikkszamRTB
            // 
            this.CikkszamRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CikkszamRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CikkszamRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.CikkszamRTB.Location = new System.Drawing.Point(359, 30);
            this.CikkszamRTB.Name = "CikkszamRTB";
            this.CikkszamRTB.Size = new System.Drawing.Size(125, 35);
            this.CikkszamRTB.TabIndex = 8;
            this.CikkszamRTB.Text = "Cikkszám";
            // 
            // DarabszamRTB
            // 
            this.DarabszamRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DarabszamRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DarabszamRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.DarabszamRTB.Location = new System.Drawing.Point(621, 30);
            this.DarabszamRTB.Name = "DarabszamRTB";
            this.DarabszamRTB.Size = new System.Drawing.Size(125, 35);
            this.DarabszamRTB.TabIndex = 7;
            this.DarabszamRTB.Text = "Darabszám";
            // 
            // VevoRTB
            // 
            this.VevoRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.VevoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VevoRTB.ForeColor = System.Drawing.SystemColors.Window;
            this.VevoRTB.Location = new System.Drawing.Point(103, 30);
            this.VevoRTB.Name = "VevoRTB";
            this.VevoRTB.Size = new System.Drawing.Size(125, 35);
            this.VevoRTB.TabIndex = 6;
            this.VevoRTB.Text = "Vevő";
            // 
            // CikkszamCBBX
            // 
            this.CikkszamCBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CikkszamCBBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikkszamCBBX.FormattingEnabled = true;
            this.CikkszamCBBX.Location = new System.Drawing.Point(295, 74);
            this.CikkszamCBBX.Name = "CikkszamCBBX";
            this.CikkszamCBBX.Size = new System.Drawing.Size(223, 31);
            this.CikkszamCBBX.TabIndex = 5;
            // 
            // VevoCBBX
            // 
            this.VevoCBBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VevoCBBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VevoCBBX.FormattingEnabled = true;
            this.VevoCBBX.Location = new System.Drawing.Point(23, 74);
            this.VevoCBBX.Name = "VevoCBBX";
            this.VevoCBBX.Size = new System.Drawing.Size(223, 31);
            this.VevoCBBX.TabIndex = 0;
            this.VevoCBBX.SelectedIndexChanged += new System.EventHandler(this.CikkszamFeltolt);
            this.VevoCBBX.Click += new System.EventHandler(this.VevoFeltolt);
            // 
            // MenuGRPBX
            // 
            this.MenuGRPBX.Controls.Add(this.KomissiozasBTN);
            this.MenuGRPBX.Controls.Add(this.SzallitoBTN);
            this.MenuGRPBX.Controls.Add(this.KomissioListaBTN);
            this.MenuGRPBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGRPBX.Location = new System.Drawing.Point(156, 43);
            this.MenuGRPBX.Name = "MenuGRPBX";
            this.MenuGRPBX.Size = new System.Drawing.Size(895, 73);
            this.MenuGRPBX.TabIndex = 7;
            this.MenuGRPBX.TabStop = false;
            // 
            // KomissiozasBTN
            // 
            this.KomissiozasBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KomissiozasBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KomissiozasBTN.ForeColor = System.Drawing.Color.White;
            this.KomissiozasBTN.Location = new System.Drawing.Point(327, 21);
            this.KomissiozasBTN.Name = "KomissiozasBTN";
            this.KomissiozasBTN.Size = new System.Drawing.Size(140, 35);
            this.KomissiozasBTN.TabIndex = 2;
            this.KomissiozasBTN.Text = "Komissiózás";
            this.KomissiozasBTN.UseVisualStyleBackColor = true;
            this.KomissiozasBTN.Click += new System.EventHandler(this.KomissiozasBTN_Click);
            // 
            // SzallitoBTN
            // 
            this.SzallitoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SzallitoBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzallitoBTN.ForeColor = System.Drawing.Color.White;
            this.SzallitoBTN.Location = new System.Drawing.Point(626, 21);
            this.SzallitoBTN.Name = "SzallitoBTN";
            this.SzallitoBTN.Size = new System.Drawing.Size(263, 35);
            this.SzallitoBTN.TabIndex = 1;
            this.SzallitoBTN.Text = "Szállítólevél nyomtatás";
            this.SzallitoBTN.UseVisualStyleBackColor = true;
            this.SzallitoBTN.Click += new System.EventHandler(this.SzallitoBTN_Click);
            // 
            // KomissioListaBTN
            // 
            this.KomissioListaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KomissioListaBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KomissioListaBTN.ForeColor = System.Drawing.Color.White;
            this.KomissioListaBTN.Location = new System.Drawing.Point(7, 21);
            this.KomissioListaBTN.Name = "KomissioListaBTN";
            this.KomissioListaBTN.Size = new System.Drawing.Size(294, 35);
            this.KomissioListaBTN.TabIndex = 0;
            this.KomissioListaBTN.Text = "Komissiózó lista nyomtatás";
            this.KomissioListaBTN.UseVisualStyleBackColor = true;
            this.KomissioListaBTN.Click += new System.EventHandler(this.KomissioListaBTN_Click);
            // 
            // printKomissiozas
            // 
            this.printKomissiozas.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printKomissiozas_PrintPage);
            // 
            // printPreviewKomissiozas
            // 
            this.printPreviewKomissiozas.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewKomissiozas.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewKomissiozas.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewKomissiozas.Document = this.printKomissiozas;
            this.printPreviewKomissiozas.Enabled = true;
            this.printPreviewKomissiozas.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewKomissiozas.Icon")));
            this.printPreviewKomissiozas.Name = "printPreviewDialog1";
            this.printPreviewKomissiozas.Visible = false;
            // 
            // printSzallito
            // 
            this.printSzallito.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSzallito_PrintPage);
            // 
            // printPreviewSzallito
            // 
            this.printPreviewSzallito.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewSzallito.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewSzallito.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewSzallito.Document = this.printSzallito;
            this.printPreviewSzallito.Enabled = true;
            this.printPreviewSzallito.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewSzallito.Icon")));
            this.printPreviewSzallito.Name = "printPreviewSzallito";
            this.printPreviewSzallito.Visible = false;
            // 
            // Kiszallitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 634);
            this.Controls.Add(this.MenuGRPBX);
            this.Controls.Add(this.KomissioGRPBX);
            this.Name = "Kiszallitas";
            this.Text = "Kiszállítás";
            this.Controls.SetChildIndex(this.KomissioGRPBX, 0);
            this.Controls.SetChildIndex(this.MenuGRPBX, 0);
            this.KomissioGRPBX.ResumeLayout(false);
            this.KomissioGRPBX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdatokDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komissiozasBindingSource)).EndInit();
            this.MenuGRPBX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KomissioGRPBX;
        private System.Windows.Forms.ComboBox CikkszamCBBX;
        private System.Windows.Forms.ComboBox VevoCBBX;
        private System.Windows.Forms.DataGridView AdatokDGV;
        private System.Windows.Forms.TextBox DarabszamTXB;
        private System.Windows.Forms.RichTextBox CikkszamRTB;
        private System.Windows.Forms.RichTextBox DarabszamRTB;
        private System.Windows.Forms.RichTextBox VevoRTB;
        private System.Windows.Forms.GroupBox MenuGRPBX;
        private System.Windows.Forms.Button SzallitoBTN;
        private System.Windows.Forms.Button KomissioListaBTN;
        private System.Windows.Forms.Button FelvetelBTN;
        private System.Windows.Forms.BindingSource komissiozasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vevoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darabszamDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printKomissiozas;
        private System.Windows.Forms.PrintPreviewDialog printPreviewKomissiozas;
        private System.Drawing.Printing.PrintDocument printSzallito;
        private System.Windows.Forms.PrintPreviewDialog printPreviewSzallito;
        private System.Windows.Forms.Button KomissiozasBTN;
    }
}