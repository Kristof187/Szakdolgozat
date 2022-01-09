
namespace Szakdolgozat
{
    partial class Kezdolap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kezdolap));
            this.menu_sav_Panel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cimkezesBtn = new System.Windows.Forms.Button();
            this.attarolasBtn = new System.Windows.Forms.Button();
            this.raktar_infoBtn = new System.Windows.Forms.Button();
            this.komissiozasBtn = new System.Windows.Forms.Button();
            this.bevetelezesBtn = new System.Windows.Forms.Button();
            this.menu_sav_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_sav_Panel
            // 
            this.menu_sav_Panel.Controls.Add(this.logo);
            this.menu_sav_Panel.Controls.Add(this.cimkezesBtn);
            this.menu_sav_Panel.Controls.Add(this.attarolasBtn);
            this.menu_sav_Panel.Controls.Add(this.raktar_infoBtn);
            this.menu_sav_Panel.Controls.Add(this.komissiozasBtn);
            this.menu_sav_Panel.Controls.Add(this.bevetelezesBtn);
            this.menu_sav_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_sav_Panel.Location = new System.Drawing.Point(0, 0);
            this.menu_sav_Panel.Name = "menu_sav_Panel";
            this.menu_sav_Panel.Size = new System.Drawing.Size(157, 634);
            this.menu_sav_Panel.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, -9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 109);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // cimkezesBtn
            // 
            this.cimkezesBtn.FlatAppearance.BorderSize = 0;
            this.cimkezesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cimkezesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimkezesBtn.ForeColor = System.Drawing.Color.White;
            this.cimkezesBtn.Location = new System.Drawing.Point(3, 191);
            this.cimkezesBtn.Name = "cimkezesBtn";
            this.cimkezesBtn.Size = new System.Drawing.Size(150, 58);
            this.cimkezesBtn.TabIndex = 5;
            this.cimkezesBtn.Text = "Címkézés";
            this.cimkezesBtn.UseVisualStyleBackColor = true;
            this.cimkezesBtn.Click += new System.EventHandler(this.CimkezesBtn_Click);
            // 
            // attarolasBtn
            // 
            this.attarolasBtn.FlatAppearance.BorderSize = 0;
            this.attarolasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attarolasBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attarolasBtn.ForeColor = System.Drawing.Color.White;
            this.attarolasBtn.Location = new System.Drawing.Point(3, 260);
            this.attarolasBtn.Name = "attarolasBtn";
            this.attarolasBtn.Size = new System.Drawing.Size(150, 58);
            this.attarolasBtn.TabIndex = 4;
            this.attarolasBtn.Text = "Áttárolás";
            this.attarolasBtn.UseVisualStyleBackColor = true;
            this.attarolasBtn.Click += new System.EventHandler(this.AttarolasBtn_Click);
            // 
            // raktar_infoBtn
            // 
            this.raktar_infoBtn.FlatAppearance.BorderSize = 0;
            this.raktar_infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktar_infoBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raktar_infoBtn.ForeColor = System.Drawing.Color.White;
            this.raktar_infoBtn.Location = new System.Drawing.Point(3, 398);
            this.raktar_infoBtn.Name = "raktar_infoBtn";
            this.raktar_infoBtn.Size = new System.Drawing.Size(150, 58);
            this.raktar_infoBtn.TabIndex = 2;
            this.raktar_infoBtn.Text = "Raktár Infó";
            this.raktar_infoBtn.UseVisualStyleBackColor = true;
            this.raktar_infoBtn.Click += new System.EventHandler(this.Raktar_infoBtn_Click);
            // 
            // komissiozasBtn
            // 
            this.komissiozasBtn.FlatAppearance.BorderSize = 0;
            this.komissiozasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.komissiozasBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komissiozasBtn.ForeColor = System.Drawing.Color.White;
            this.komissiozasBtn.Location = new System.Drawing.Point(3, 329);
            this.komissiozasBtn.Name = "komissiozasBtn";
            this.komissiozasBtn.Size = new System.Drawing.Size(150, 58);
            this.komissiozasBtn.TabIndex = 1;
            this.komissiozasBtn.Text = "Kiszállítás";
            this.komissiozasBtn.UseVisualStyleBackColor = true;
            this.komissiozasBtn.Click += new System.EventHandler(this.KiszallitasBtn_Click);
            // 
            // bevetelezesBtn
            // 
            this.bevetelezesBtn.FlatAppearance.BorderSize = 0;
            this.bevetelezesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bevetelezesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bevetelezesBtn.ForeColor = System.Drawing.Color.White;
            this.bevetelezesBtn.Location = new System.Drawing.Point(3, 122);
            this.bevetelezesBtn.Name = "bevetelezesBtn";
            this.bevetelezesBtn.Size = new System.Drawing.Size(150, 58);
            this.bevetelezesBtn.TabIndex = 0;
            this.bevetelezesBtn.Text = "Bevételezés";
            this.bevetelezesBtn.UseVisualStyleBackColor = true;
            this.bevetelezesBtn.Click += new System.EventHandler(this.BevetelezesBtn_Click);
            // 
            // Kezdolap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 634);
            this.Controls.Add(this.menu_sav_Panel);
            this.Name = "Kezdolap";
            this.Text = "Kezdőlap";
            this.Controls.SetChildIndex(this.menu_sav_Panel, 0);
            this.menu_sav_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_sav_Panel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button cimkezesBtn;
        private System.Windows.Forms.Button attarolasBtn;
        private System.Windows.Forms.Button raktar_infoBtn;
        private System.Windows.Forms.Button komissiozasBtn;
        private System.Windows.Forms.Button bevetelezesBtn;
    }
}