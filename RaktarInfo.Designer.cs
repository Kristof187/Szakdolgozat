
namespace Szakdolgozat
{
    partial class RaktarInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.KeresesGRPBX = new System.Windows.Forms.GroupBox();
            this.MindenKonyvelCHBX = new System.Windows.Forms.CheckBox();
            this.KonyvelesFajtaCBBX = new System.Windows.Forms.ComboBox();
            this.DatumDTP = new System.Windows.Forms.DateTimePicker();
            this.LokacioCBBX = new System.Windows.Forms.ComboBox();
            this.CikkszamCBBX = new System.Windows.Forms.ComboBox();
            this.KonyvelesFajtaRTB = new System.Windows.Forms.RichTextBox();
            this.DatumRTB = new System.Windows.Forms.RichTextBox();
            this.LokacioRTB = new System.Windows.Forms.RichTextBox();
            this.CikkszamRTB = new System.Windows.Forms.RichTextBox();
            this.AdatokDGV = new System.Windows.Forms.DataGridView();
            this.lekerdezesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuGRPBX = new System.Windows.Forms.GroupBox();
            this.TorlesBTN = new System.Windows.Forms.Button();
            this.KeresesBTN = new System.Windows.Forms.Button();
            this.fIFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darabszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konyvelesFajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeresesGRPBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdatokDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekerdezesBindingSource)).BeginInit();
            this.MenuGRPBX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fIFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KeresesGRPBX
            // 
            this.KeresesGRPBX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KeresesGRPBX.Controls.Add(this.MindenKonyvelCHBX);
            this.KeresesGRPBX.Controls.Add(this.KonyvelesFajtaCBBX);
            this.KeresesGRPBX.Controls.Add(this.DatumDTP);
            this.KeresesGRPBX.Controls.Add(this.LokacioCBBX);
            this.KeresesGRPBX.Controls.Add(this.CikkszamCBBX);
            this.KeresesGRPBX.Controls.Add(this.KonyvelesFajtaRTB);
            this.KeresesGRPBX.Controls.Add(this.DatumRTB);
            this.KeresesGRPBX.Controls.Add(this.LokacioRTB);
            this.KeresesGRPBX.Controls.Add(this.CikkszamRTB);
            this.KeresesGRPBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeresesGRPBX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeresesGRPBX.ForeColor = System.Drawing.Color.White;
            this.KeresesGRPBX.Location = new System.Drawing.Point(28, 108);
            this.KeresesGRPBX.Name = "KeresesGRPBX";
            this.KeresesGRPBX.Size = new System.Drawing.Size(1103, 176);
            this.KeresesGRPBX.TabIndex = 10;
            this.KeresesGRPBX.TabStop = false;
            // 
            // MindenKonyvelCHBX
            // 
            this.MindenKonyvelCHBX.AutoSize = true;
            this.MindenKonyvelCHBX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MindenKonyvelCHBX.Location = new System.Drawing.Point(871, 85);
            this.MindenKonyvelCHBX.Name = "MindenKonyvelCHBX";
            this.MindenKonyvelCHBX.Size = new System.Drawing.Size(207, 27);
            this.MindenKonyvelCHBX.TabIndex = 16;
            this.MindenKonyvelCHBX.Text = "Minden könyvelés";
            this.MindenKonyvelCHBX.UseVisualStyleBackColor = true;
            this.MindenKonyvelCHBX.Click += new System.EventHandler(this.MindenKonyvelCHBX_Click);
            // 
            // KonyvelesFajtaCBBX
            // 
            this.KonyvelesFajtaCBBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KonyvelesFajtaCBBX.FormattingEnabled = true;
            this.KonyvelesFajtaCBBX.Location = new System.Drawing.Point(877, 118);
            this.KonyvelesFajtaCBBX.Name = "KonyvelesFajtaCBBX";
            this.KonyvelesFajtaCBBX.Size = new System.Drawing.Size(202, 31);
            this.KonyvelesFajtaCBBX.TabIndex = 15;
            this.KonyvelesFajtaCBBX.Click += new System.EventHandler(this.KonyvelesFajtaCBBX_SelectedIndexChanged);
            // 
            // DatumDTP
            // 
            this.DatumDTP.Checked = false;
            this.DatumDTP.CustomFormat = " ";
            this.DatumDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumDTP.Location = new System.Drawing.Point(41, 118);
            this.DatumDTP.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatumDTP.Name = "DatumDTP";
            this.DatumDTP.Size = new System.Drawing.Size(202, 32);
            this.DatumDTP.TabIndex = 14;
            this.DatumDTP.CloseUp += new System.EventHandler(this.DatumDTP_CloseUp);
            // 
            // LokacioCBBX
            // 
            this.LokacioCBBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LokacioCBBX.FormattingEnabled = true;
            this.LokacioCBBX.Location = new System.Drawing.Point(616, 118);
            this.LokacioCBBX.Name = "LokacioCBBX";
            this.LokacioCBBX.Size = new System.Drawing.Size(202, 31);
            this.LokacioCBBX.TabIndex = 13;
            this.LokacioCBBX.Click += new System.EventHandler(this.LokacioCBBX_SelectedIndexChanged);
            // 
            // CikkszamCBBX
            // 
            this.CikkszamCBBX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikkszamCBBX.FormattingEnabled = true;
            this.CikkszamCBBX.Location = new System.Drawing.Point(311, 118);
            this.CikkszamCBBX.Name = "CikkszamCBBX";
            this.CikkszamCBBX.Size = new System.Drawing.Size(242, 31);
            this.CikkszamCBBX.TabIndex = 10;
            this.CikkszamCBBX.Click += new System.EventHandler(this.CikkszamCBBX_Click);
            // 
            // KonyvelesFajtaRTB
            // 
            this.KonyvelesFajtaRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.KonyvelesFajtaRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KonyvelesFajtaRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KonyvelesFajtaRTB.ForeColor = System.Drawing.Color.White;
            this.KonyvelesFajtaRTB.Location = new System.Drawing.Point(877, 28);
            this.KonyvelesFajtaRTB.Name = "KonyvelesFajtaRTB";
            this.KonyvelesFajtaRTB.ReadOnly = true;
            this.KonyvelesFajtaRTB.Size = new System.Drawing.Size(185, 36);
            this.KonyvelesFajtaRTB.TabIndex = 4;
            this.KonyvelesFajtaRTB.Text = "Könyvelés fajtája";
            // 
            // DatumRTB
            // 
            this.DatumRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DatumRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatumRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumRTB.ForeColor = System.Drawing.Color.White;
            this.DatumRTB.Location = new System.Drawing.Point(60, 28);
            this.DatumRTB.Name = "DatumRTB";
            this.DatumRTB.ReadOnly = true;
            this.DatumRTB.Size = new System.Drawing.Size(186, 36);
            this.DatumRTB.TabIndex = 3;
            this.DatumRTB.Text = " Könyvelés dátuma";
            // 
            // LokacioRTB
            // 
            this.LokacioRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LokacioRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LokacioRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LokacioRTB.ForeColor = System.Drawing.Color.White;
            this.LokacioRTB.Location = new System.Drawing.Point(684, 28);
            this.LokacioRTB.Name = "LokacioRTB";
            this.LokacioRTB.ReadOnly = true;
            this.LokacioRTB.Size = new System.Drawing.Size(118, 36);
            this.LokacioRTB.TabIndex = 1;
            this.LokacioRTB.Text = "Lokáció";
            // 
            // CikkszamRTB
            // 
            this.CikkszamRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CikkszamRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CikkszamRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CikkszamRTB.ForeColor = System.Drawing.Color.White;
            this.CikkszamRTB.Location = new System.Drawing.Point(383, 28);
            this.CikkszamRTB.Name = "CikkszamRTB";
            this.CikkszamRTB.ReadOnly = true;
            this.CikkszamRTB.Size = new System.Drawing.Size(125, 36);
            this.CikkszamRTB.TabIndex = 0;
            this.CikkszamRTB.Text = "Cikkszám";
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
            this.Column1,
            this.cikkszamDataGridViewTextBoxColumn,
            this.darabszam,
            this.lokacioDataGridViewTextBoxColumn,
            this.konyvelesFajta});
            this.AdatokDGV.DataSource = this.lekerdezesBindingSource;
            this.AdatokDGV.GridColor = System.Drawing.Color.Black;
            this.AdatokDGV.Location = new System.Drawing.Point(28, 279);
            this.AdatokDGV.Name = "AdatokDGV";
            this.AdatokDGV.RowHeadersWidth = 51;
            this.AdatokDGV.RowTemplate.Height = 24;
            this.AdatokDGV.Size = new System.Drawing.Size(1103, 328);
            this.AdatokDGV.TabIndex = 11;
            // 
            // lekerdezesBindingSource
            // 
            this.lekerdezesBindingSource.DataSource = typeof(Szakdolgozat.Lekerdezes);
            // 
            // MenuGRPBX
            // 
            this.MenuGRPBX.Controls.Add(this.TorlesBTN);
            this.MenuGRPBX.Controls.Add(this.KeresesBTN);
            this.MenuGRPBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuGRPBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MenuGRPBX.ForeColor = System.Drawing.Color.White;
            this.MenuGRPBX.Location = new System.Drawing.Point(774, 40);
            this.MenuGRPBX.Name = "MenuGRPBX";
            this.MenuGRPBX.Size = new System.Drawing.Size(357, 78);
            this.MenuGRPBX.TabIndex = 12;
            this.MenuGRPBX.TabStop = false;
            // 
            // TorlesBTN
            // 
            this.TorlesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TorlesBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TorlesBTN.Location = new System.Drawing.Point(19, 22);
            this.TorlesBTN.Name = "TorlesBTN";
            this.TorlesBTN.Size = new System.Drawing.Size(147, 40);
            this.TorlesBTN.TabIndex = 2;
            this.TorlesBTN.Text = "Törlés";
            this.TorlesBTN.UseVisualStyleBackColor = true;
            this.TorlesBTN.Click += new System.EventHandler(this.TorlesBTN_Click);
            // 
            // KeresesBTN
            // 
            this.KeresesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeresesBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeresesBTN.Location = new System.Drawing.Point(189, 22);
            this.KeresesBTN.Name = "KeresesBTN";
            this.KeresesBTN.Size = new System.Drawing.Size(147, 40);
            this.KeresesBTN.TabIndex = 0;
            this.KeresesBTN.Text = "Keresés";
            this.KeresesBTN.UseVisualStyleBackColor = true;
            this.KeresesBTN.Click += new System.EventHandler(this.KeresesBTN_Click);
            // 
            // fIFOBindingSource
            // 
            this.fIFOBindingSource.DataSource = typeof(Szakdolgozat.FIFO);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "datum";
            this.Column1.HeaderText = "Dátum";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 200;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "cikkszam";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.cikkszamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkszamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cikkszamDataGridViewTextBoxColumn.Width = 200;
            // 
            // darabszam
            // 
            this.darabszam.DataPropertyName = "darabszam";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.darabszam.DefaultCellStyle = dataGridViewCellStyle5;
            this.darabszam.HeaderText = "Darabszam";
            this.darabszam.MinimumWidth = 20;
            this.darabszam.Name = "darabszam";
            this.darabszam.ReadOnly = true;
            this.darabszam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.darabszam.Width = 200;
            // 
            // lokacioDataGridViewTextBoxColumn
            // 
            this.lokacioDataGridViewTextBoxColumn.DataPropertyName = "lokacio";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.lokacioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.lokacioDataGridViewTextBoxColumn.HeaderText = "Lokáció";
            this.lokacioDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.lokacioDataGridViewTextBoxColumn.Name = "lokacioDataGridViewTextBoxColumn";
            this.lokacioDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lokacioDataGridViewTextBoxColumn.Width = 200;
            // 
            // konyvelesFajta
            // 
            this.konyvelesFajta.DataPropertyName = "konyvelesFajta";
            this.konyvelesFajta.HeaderText = "Könyvelés Fajtája";
            this.konyvelesFajta.MinimumWidth = 6;
            this.konyvelesFajta.Name = "konyvelesFajta";
            this.konyvelesFajta.ReadOnly = true;
            this.konyvelesFajta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.konyvelesFajta.Width = 200;
            // 
            // RaktarInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 634);
            this.Controls.Add(this.AdatokDGV);
            this.Controls.Add(this.MenuGRPBX);
            this.Controls.Add(this.KeresesGRPBX);
            this.Name = "RaktarInfo";
            this.Text = "RaktarInfo";
            this.Controls.SetChildIndex(this.KeresesGRPBX, 0);
            this.Controls.SetChildIndex(this.MenuGRPBX, 0);
            this.Controls.SetChildIndex(this.AdatokDGV, 0);
            this.KeresesGRPBX.ResumeLayout(false);
            this.KeresesGRPBX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdatokDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekerdezesBindingSource)).EndInit();
            this.MenuGRPBX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fIFOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KeresesGRPBX;
        private System.Windows.Forms.DataGridView AdatokDGV;
        private System.Windows.Forms.RichTextBox KonyvelesFajtaRTB;
        private System.Windows.Forms.RichTextBox DatumRTB;
        private System.Windows.Forms.RichTextBox LokacioRTB;
        private System.Windows.Forms.RichTextBox CikkszamRTB;
        private System.Windows.Forms.GroupBox MenuGRPBX;
        private System.Windows.Forms.Button KeresesBTN;
        private System.Windows.Forms.ComboBox CikkszamCBBX;
        private System.Windows.Forms.ComboBox LokacioCBBX;
        private System.Windows.Forms.DateTimePicker DatumDTP;
        private System.Windows.Forms.ComboBox KonyvelesFajtaCBBX;
        private System.Windows.Forms.Button TorlesBTN;
        private System.Windows.Forms.CheckBox MindenKonyvelCHBX;
        private System.Windows.Forms.BindingSource lekerdezesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvelesFajtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fIFOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darabszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvelesFajta;
    }
}