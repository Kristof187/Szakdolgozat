
namespace Szakdolgozat
{
    partial class Sablon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected virtual void Dispose(bool disposing)
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
        protected virtual void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sablon));
            this.hatterPanel = new System.Windows.Forms.Panel();
            this.fejlecPanel = new System.Windows.Forms.Panel();
            this.minimalizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.fejlecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hatterPanel
            // 
            this.hatterPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hatterPanel.BackgroundImage")));
            this.hatterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hatterPanel.Location = new System.Drawing.Point(1, 40);
            this.hatterPanel.Name = "hatterPanel";
            this.hatterPanel.Size = new System.Drawing.Size(1154, 591);
            this.hatterPanel.TabIndex = 3;
            // 
            // fejlecPanel
            // 
            this.fejlecPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fejlecPanel.Controls.Add(this.minimalizeBtn);
            this.fejlecPanel.Controls.Add(this.exitBtn);
            this.fejlecPanel.Location = new System.Drawing.Point(156, 0);
            this.fejlecPanel.Name = "fejlecPanel";
            this.fejlecPanel.Size = new System.Drawing.Size(1002, 43);
            this.fejlecPanel.TabIndex = 5;
            this.fejlecPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sablon_MouseDown);
            this.fejlecPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sablon_MouseMove);
            this.fejlecPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sablon_MouseUp);
            // 
            // minimalizeBtn
            // 
            this.minimalizeBtn.BackColor = System.Drawing.Color.DimGray;
            this.minimalizeBtn.FlatAppearance.BorderSize = 0;
            this.minimalizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimalizeBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimalizeBtn.Location = new System.Drawing.Point(909, 3);
            this.minimalizeBtn.Name = "minimalizeBtn";
            this.minimalizeBtn.Size = new System.Drawing.Size(42, 36);
            this.minimalizeBtn.TabIndex = 1;
            this.minimalizeBtn.Text = "_";
            this.minimalizeBtn.UseVisualStyleBackColor = false;
            this.minimalizeBtn.Click += new System.EventHandler(this.MinimalizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Maroon;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(957, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 36);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Location = new System.Drawing.Point(0, -9);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(157, 109);
            this.logoPanel.TabIndex = 6;
            this.logoPanel.Click += new System.EventHandler(this.Kezdolapra_Click);
            // 
            // Sablon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1155, 634);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.hatterPanel);
            this.Controls.Add(this.fejlecPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sablon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.fejlecPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hatterPanel;
        private System.Windows.Forms.Panel fejlecPanel;
        private System.Windows.Forms.Button minimalizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel logoPanel;
    }
}