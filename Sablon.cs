using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Sablon : Form
    {
        protected bool huzas = false;
        protected Point kurzorPont;
        protected Point formPont;
        public Sablon()
        {
            InitializeComponent();
        }
        protected virtual void SetExitBtn(int x, int y)
        {
            this.exitBtn.Location = new Point(x,y);
        }

        protected virtual void SetMinimalizeBtn(int x, int y)
        {
            this.minimalizeBtn.Location = new Point(x,y);
        }

        protected void Sablon_MouseDown(object sender, MouseEventArgs e)
        {
            huzas = true;
            kurzorPont = Cursor.Position;
            formPont = this.Location;
        }
        protected void Sablon_MouseMove(object sender, MouseEventArgs e)
        {
            if (huzas)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(kurzorPont));
                this.Location = Point.Add(formPont, new Size(dif));
            }
        }
        protected void Sablon_MouseUp(object sender, MouseEventArgs e)
        {
            huzas = false;
        }

        protected virtual void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void MinimalizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected void Kezdolapra_Click(object sender, EventArgs e)
        {
            (new Kezdolap()).Show();
            this.Close();
        }
        protected virtual void BetuSzinBeallito(object sender)
        {
            string uzenet = "*";
            Color piros = Color.Red;
            RichTextBox richTextBox = sender as RichTextBox;
            richTextBox.SelectionStart = richTextBox.TextLength;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectionColor = piros;
            richTextBox.AppendText(uzenet);
            richTextBox.SelectionColor = richTextBox.ForeColor;
        }
        protected virtual void SzamEllenorzes(object sender, EventArgs e)
        {
            TextBox textBoxNeve = sender as TextBox;
            string beirtDarabszam = textBoxNeve.Text;
            if (Regex.IsMatch(beirtDarabszam, "^[0-9]+$") && long.Parse(beirtDarabszam) != 0)
            {
                textBoxNeve.Text = beirtDarabszam;
            }
            else
            {
                textBoxNeve.Clear();
            }
        }
    }
}
