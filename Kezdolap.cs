using System;

namespace Szakdolgozat
{
    public partial class Kezdolap : Sablon
    {
        public Kezdolap()
        {
            InitializeComponent();
        }

        private void BevetelezesBtn_Click(object sender, EventArgs e)
        {
            new Bevetelezes().Show();
        }

        private void CimkezesBtn_Click(object sender, EventArgs e)
        {
            new Cimkezes().Show();
        }

        private void AttarolasBtn_Click(object sender, EventArgs e)
        {
            new Attarolas().Show();
        }

        private void KiszallitasBtn_Click(object sender, EventArgs e)
        {
            new Kiszallitas().Show();
        }

        private void Raktar_infoBtn_Click(object sender, EventArgs e)
        {
            new RaktarInfo().Show();
        }
    }
}
