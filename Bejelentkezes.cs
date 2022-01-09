using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Bejelentkezes : Form
    {
        private static int felhasznaloID;
        private static string felhasznaloNev;

        public Bejelentkezes()
        {
            InitializeComponent();
            Adatbazis adatbazis = new Adatbazis();
            jelszo_Txtbox.PasswordChar = '*';
        }

        public bool BejelentkezesEllenorzes(string userName, string password)
        {
            bool vizsgalat = false;
            List<string> felhasznalo = Adatbazis.Lekerdezes(TablaNevek.felhasznalo, OszlopNevek.FelhasznaloNev);
            List<string> jelszo = Adatbazis.Lekerdezes(TablaNevek.felhasznalo, OszlopNevek.Jelszo);

            int i = 0;
            while (i < felhasznalo.Count)
            {
                if (felhasznalo[i] == userName && jelszo[i] == password)
                {
                    vizsgalat = true;
                    felhasznaloNev = felhasznalo[i];
                }
                i++;
            }
            return vizsgalat;
        }

        private void minimalizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bejelentkezesBtn_Click(object sender, EventArgs e)
        {
            string beirtNev = felhasznalo_Txtbox.Text;
            string beirtJelszo = jelszo_Txtbox.Text;
            if (String.IsNullOrEmpty(beirtNev) || String.IsNullOrEmpty(beirtJelszo))
            {
                MessageBox.Show("Kérem adjon meg egy felhasznélónevet és egy jelszót!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (BejelentkezesEllenorzes(beirtNev, beirtJelszo))
            {
                new Kezdolap().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                felhasznalo_Txtbox.Clear();
                jelszo_Txtbox.Clear();
            }
        }

        internal static int GetFelhasznaloID()
        {
            string where = $"{OszlopNevek.FelhasznaloNev}='{felhasznaloNev}'";
            felhasznaloID = int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.felhasznalo, OszlopNevek.FelhasznaloID, where));
            return felhasznaloID;
        }
    }
}
