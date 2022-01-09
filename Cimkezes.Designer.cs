
namespace Szakdolgozat
{
    partial class Cimkezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cimkezes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NyomtatottDb_RTB = new System.Windows.Forms.RichTextBox();
            this.LokacioRTB = new System.Windows.Forms.RichTextBox();
            this.DarabszamRTB = new System.Windows.Forms.RichTextBox();
            this.CikkszamRTB = new System.Windows.Forms.RichTextBox();
            this.NyomtatottDB_NumUD = new System.Windows.Forms.NumericUpDown();
            this.NyomtatasBtn = new System.Windows.Forms.Button();
            this.MegjegyzTxtBox = new System.Windows.Forms.TextBox();
            this.DarabszTxtBox = new System.Windows.Forms.TextBox();
            this.MegnTxtBox = new System.Windows.Forms.TextBox();
            this.VevoiCikkTxtBox = new System.Windows.Forms.TextBox();
            this.MegjegyzesLbl = new System.Windows.Forms.Label();
            this.LokacioCBox = new System.Windows.Forms.ComboBox();
            this.CikkszamCBox = new System.Windows.Forms.ComboBox();
            this.VevoiCikkSzLbl = new System.Windows.Forms.Label();
            this.MegnevezesLbl = new System.Windows.Forms.Label();
            this.cimkeNyomtatas = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NyomtatottDB_NumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.NyomtatottDb_RTB);
            this.groupBox1.Controls.Add(this.LokacioRTB);
            this.groupBox1.Controls.Add(this.DarabszamRTB);
            this.groupBox1.Controls.Add(this.CikkszamRTB);
            this.groupBox1.Controls.Add(this.NyomtatottDB_NumUD);
            this.groupBox1.Controls.Add(this.NyomtatasBtn);
            this.groupBox1.Controls.Add(this.MegjegyzTxtBox);
            this.groupBox1.Controls.Add(this.DarabszTxtBox);
            this.groupBox1.Controls.Add(this.MegnTxtBox);
            this.groupBox1.Controls.Add(this.VevoiCikkTxtBox);
            this.groupBox1.Controls.Add(this.MegjegyzesLbl);
            this.groupBox1.Controls.Add(this.LokacioCBox);
            this.groupBox1.Controls.Add(this.CikkszamCBox);
            this.groupBox1.Controls.Add(this.VevoiCikkSzLbl);
            this.groupBox1.Controls.Add(this.MegnevezesLbl);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(40, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 403);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // NyomtatottDb_RTB
            // 
            this.NyomtatottDb_RTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.NyomtatottDb_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NyomtatottDb_RTB.Font = new System.Drawing.Font("Century Gothic", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NyomtatottDb_RTB.ForeColor = System.Drawing.Color.White;
            this.NyomtatottDb_RTB.Location = new System.Drawing.Point(20, 282);
            this.NyomtatottDb_RTB.Name = "NyomtatottDb_RTB";
            this.NyomtatottDb_RTB.Size = new System.Drawing.Size(189, 24);
            this.NyomtatottDb_RTB.TabIndex = 18;
            this.NyomtatottDb_RTB.Text = "Nyomtatott darab";
            // 
            // LokacioRTB
            // 
            this.LokacioRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.LokacioRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LokacioRTB.Font = new System.Drawing.Font("Century Gothic", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LokacioRTB.ForeColor = System.Drawing.Color.White;
            this.LokacioRTB.Location = new System.Drawing.Point(20, 199);
            this.LokacioRTB.Name = "LokacioRTB";
            this.LokacioRTB.Size = new System.Drawing.Size(137, 24);
            this.LokacioRTB.TabIndex = 17;
            this.LokacioRTB.Text = "Lokáció";
            // 
            // DarabszamRTB
            // 
            this.DarabszamRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DarabszamRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DarabszamRTB.Font = new System.Drawing.Font("Century Gothic", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DarabszamRTB.ForeColor = System.Drawing.Color.White;
            this.DarabszamRTB.Location = new System.Drawing.Point(19, 160);
            this.DarabszamRTB.Name = "DarabszamRTB";
            this.DarabszamRTB.Size = new System.Drawing.Size(137, 24);
            this.DarabszamRTB.TabIndex = 16;
            this.DarabszamRTB.Text = "Darabszám";
            // 
            // CikkszamRTB
            // 
            this.CikkszamRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CikkszamRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CikkszamRTB.Font = new System.Drawing.Font("Century Gothic", 10.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CikkszamRTB.ForeColor = System.Drawing.Color.White;
            this.CikkszamRTB.Location = new System.Drawing.Point(19, 44);
            this.CikkszamRTB.Name = "CikkszamRTB";
            this.CikkszamRTB.Size = new System.Drawing.Size(137, 24);
            this.CikkszamRTB.TabIndex = 15;
            this.CikkszamRTB.Text = "Cikkszám";
            // 
            // NyomtatottDB_NumUD
            // 
            this.NyomtatottDB_NumUD.BackColor = System.Drawing.SystemColors.Window;
            this.NyomtatottDB_NumUD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.NyomtatottDB_NumUD.Location = new System.Drawing.Point(234, 278);
            this.NyomtatottDB_NumUD.Name = "NyomtatottDB_NumUD";
            this.NyomtatottDB_NumUD.Size = new System.Drawing.Size(46, 28);
            this.NyomtatottDB_NumUD.TabIndex = 14;
            this.NyomtatottDB_NumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NyomtatasBtn
            // 
            this.NyomtatasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NyomtatasBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NyomtatasBtn.ForeColor = System.Drawing.Color.White;
            this.NyomtatasBtn.Location = new System.Drawing.Point(136, 330);
            this.NyomtatasBtn.Name = "NyomtatasBtn";
            this.NyomtatasBtn.Size = new System.Drawing.Size(163, 40);
            this.NyomtatasBtn.TabIndex = 12;
            this.NyomtatasBtn.Text = "Nyomtatás";
            this.NyomtatasBtn.UseVisualStyleBackColor = true;
            this.NyomtatasBtn.Click += new System.EventHandler(this.NyomtatasBtn_Click);
            // 
            // MegjegyzTxtBox
            // 
            this.MegjegyzTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.MegjegyzTxtBox.Location = new System.Drawing.Point(199, 237);
            this.MegjegyzTxtBox.MaxLength = 20;
            this.MegjegyzTxtBox.Name = "MegjegyzTxtBox";
            this.MegjegyzTxtBox.Size = new System.Drawing.Size(196, 28);
            this.MegjegyzTxtBox.TabIndex = 11;
            // 
            // DarabszTxtBox
            // 
            this.DarabszTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.DarabszTxtBox.Location = new System.Drawing.Point(199, 160);
            this.DarabszTxtBox.MaxLength = 11;
            this.DarabszTxtBox.Name = "DarabszTxtBox";
            this.DarabszTxtBox.Size = new System.Drawing.Size(196, 28);
            this.DarabszTxtBox.TabIndex = 10;
            this.DarabszTxtBox.TextChanged += new System.EventHandler(this.SzamEllenorzes);
            // 
            // MegnTxtBox
            // 
            this.MegnTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.MegnTxtBox.Location = new System.Drawing.Point(199, 121);
            this.MegnTxtBox.Name = "MegnTxtBox";
            this.MegnTxtBox.ReadOnly = true;
            this.MegnTxtBox.Size = new System.Drawing.Size(196, 28);
            this.MegnTxtBox.TabIndex = 9;
            // 
            // VevoiCikkTxtBox
            // 
            this.VevoiCikkTxtBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VevoiCikkTxtBox.Location = new System.Drawing.Point(198, 82);
            this.VevoiCikkTxtBox.Name = "VevoiCikkTxtBox";
            this.VevoiCikkTxtBox.ReadOnly = true;
            this.VevoiCikkTxtBox.Size = new System.Drawing.Size(196, 28);
            this.VevoiCikkTxtBox.TabIndex = 8;
            this.VevoiCikkTxtBox.TextChanged += new System.EventHandler(this.MegnevezesFeltolt);
            // 
            // MegjegyzesLbl
            // 
            this.MegjegyzesLbl.AutoSize = true;
            this.MegjegyzesLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MegjegyzesLbl.ForeColor = System.Drawing.Color.White;
            this.MegjegyzesLbl.Location = new System.Drawing.Point(16, 237);
            this.MegjegyzesLbl.Name = "MegjegyzesLbl";
            this.MegjegyzesLbl.Size = new System.Drawing.Size(109, 19);
            this.MegjegyzesLbl.TabIndex = 7;
            this.MegjegyzesLbl.Text = "Megjegyzés";
            // 
            // LokacioCBox
            // 
            this.LokacioCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LokacioCBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.LokacioCBox.FormattingEnabled = true;
            this.LokacioCBox.Location = new System.Drawing.Point(198, 199);
            this.LokacioCBox.Name = "LokacioCBox";
            this.LokacioCBox.Size = new System.Drawing.Size(197, 27);
            this.LokacioCBox.TabIndex = 6;
            this.LokacioCBox.Click += new System.EventHandler(this.LokacioFeltoltes);
            // 
            // CikkszamCBox
            // 
            this.CikkszamCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CikkszamCBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikkszamCBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CikkszamCBox.FormattingEnabled = true;
            this.CikkszamCBox.Location = new System.Drawing.Point(198, 44);
            this.CikkszamCBox.Name = "CikkszamCBox";
            this.CikkszamCBox.Size = new System.Drawing.Size(197, 27);
            this.CikkszamCBox.TabIndex = 5;
            this.CikkszamCBox.TextChanged += new System.EventHandler(this.VevoiCikkFeltoltes);
            this.CikkszamCBox.Click += new System.EventHandler(this.CikkszamFeltoltes);
            // 
            // VevoiCikkSzLbl
            // 
            this.VevoiCikkSzLbl.AutoSize = true;
            this.VevoiCikkSzLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VevoiCikkSzLbl.ForeColor = System.Drawing.Color.White;
            this.VevoiCikkSzLbl.Location = new System.Drawing.Point(16, 82);
            this.VevoiCikkSzLbl.Name = "VevoiCikkSzLbl";
            this.VevoiCikkSzLbl.Size = new System.Drawing.Size(140, 19);
            this.VevoiCikkSzLbl.TabIndex = 4;
            this.VevoiCikkSzLbl.Text = "Vevői cikkszám";
            // 
            // MegnevezesLbl
            // 
            this.MegnevezesLbl.AutoSize = true;
            this.MegnevezesLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MegnevezesLbl.ForeColor = System.Drawing.Color.White;
            this.MegnevezesLbl.Location = new System.Drawing.Point(16, 121);
            this.MegnevezesLbl.Name = "MegnevezesLbl";
            this.MegnevezesLbl.Size = new System.Drawing.Size(115, 19);
            this.MegnevezesLbl.TabIndex = 3;
            this.MegnevezesLbl.Text = "Megnevezés";
            // 
            // cimkeNyomtatas
            // 
            this.cimkeNyomtatas.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.cimkeNyomtatas_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.cimkeNyomtatas;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Cimkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 571);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cimkezes";
            this.Text = "Címkézés";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NyomtatottDB_NumUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NyomtatasBtn;
        private System.Windows.Forms.TextBox MegjegyzTxtBox;
        private System.Windows.Forms.TextBox DarabszTxtBox;
        private System.Windows.Forms.TextBox MegnTxtBox;
        private System.Windows.Forms.TextBox VevoiCikkTxtBox;
        private System.Windows.Forms.Label MegjegyzesLbl;
        private System.Windows.Forms.ComboBox LokacioCBox;
        private System.Windows.Forms.ComboBox CikkszamCBox;
        private System.Windows.Forms.Label VevoiCikkSzLbl;
        private System.Windows.Forms.Label MegnevezesLbl;
        private System.Drawing.Printing.PrintDocument cimkeNyomtatas;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.NumericUpDown NyomtatottDB_NumUD;
        private System.Windows.Forms.RichTextBox NyomtatottDb_RTB;
        private System.Windows.Forms.RichTextBox LokacioRTB;
        private System.Windows.Forms.RichTextBox DarabszamRTB;
        private System.Windows.Forms.RichTextBox CikkszamRTB;
    }
}