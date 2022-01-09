using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class RaktarInfo : Sablon
    {
        private void DataGridViewBeallitas()
        {
            AdatokDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            AdatokDGV.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            AdatokDGV.DefaultCellStyle.ForeColor = Color.Black;
            AdatokDGV.DefaultCellStyle.BackColor = Color.White;
        }

        public RaktarInfo()
        {
            InitializeComponent();
            DataGridViewBeallitas();
        }

        private void DatumDTP_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker datumNeve = sender as DateTimePicker;
            datumNeve.Format = DateTimePickerFormat.Short;
            datumNeve.Checked = true;
        }

        private void CikkszamCBBX_Click(object sender, EventArgs e)
        {
            ComboBox comboboxNeve = sender as ComboBox;
            List<string> lekerdezes = Adatbazis.Lekerdezes(TablaNevek.cikkek, OszlopNevek.CikkID, OszlopNevek.VallalatMegjegyzes);
            int elemekSzama = comboboxNeve.Items.Count;
            if (elemekSzama < lekerdezes.Count)
            {
                comboboxNeve.Items.AddRange(lekerdezes.ToArray());
            }
        }

        private void KonyvelesFajtaCBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboboxNeve = sender as ComboBox;
            List<string> lista = Enum.GetNames(typeof(AnyagmozgasKommentek)).ToList();
            int elemekSzama = comboboxNeve.Items.Count;
            if (elemekSzama < lista.Count)
            {
                comboboxNeve.Items.AddRange(lista.ToArray());
            }    
        }

        private void LokacioCBBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboboxNeve = sender as ComboBox;
            List<string> lekerdezes = Adatbazis.Lekerdezes(TablaNevek.raktar,OszlopNevek.LokacioID);
            lekerdezes.Sort();
            int elemekszama = comboboxNeve.Items.Count;
            if (elemekszama < lekerdezes.Count)
            {
                comboboxNeve.Items.AddRange(lekerdezes.ToArray());
            }
        }

        private void MindenKonyvelCHBX_Click(object sender, EventArgs e)
        {
            if (MindenKonyvelCHBX.Checked == true)
            {
                KonyvelesFajtaCBBX.SelectedIndex = -1;
                KonyvelesFajtaCBBX.Enabled = false;
            }
            else
            {
                KonyvelesFajtaCBBX.Enabled = true;
            }
        }

        private void TorlesBTN_Click(object sender, EventArgs e)
        {
            DatumDTP.Format = DateTimePickerFormat.Custom;
            DatumDTP.Checked = false;
            CikkszamCBBX.SelectedIndex = -1;
            KonyvelesFajtaCBBX.SelectedIndex = -1;
            LokacioCBBX.SelectedIndex = -1;
            MindenKonyvelCHBX.Checked = false;
            AdatokDGV.Rows.Clear();
            AdatokDGV.Refresh();
        }
        

        protected override void BetuSzinBeallito(object sender)
        {
            base.BetuSzinBeallito(sender);
        }

        List<Lekerdezes> lekerdezes = new List<Lekerdezes>();

        private void KeresesBTN_Click(object sender, EventArgs e)
        {
            AdatokDGV.Rows.Clear();
            AdatokDGV.Refresh();
            lekerdezes.Clear();
            string datum ;
            string cikkszam;
            string lokacio;
            string konyvelesFajta;
            string where = "";

            if (DatumDTP.Checked == false && CikkszamCBBX.SelectedIndex == -1 && LokacioCBBX.SelectedIndex == -1)
            {
                string hibaUzenet = "Legalább egyet választania kell a *-gal jelzett mezők közül!";
                MessageBox.Show(hibaUzenet, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(DatumRTB.Text != " Könyvelés dátuma*")
                {
                    BetuSzinBeallito(DatumRTB);
                    BetuSzinBeallito(CikkszamRTB);
                    BetuSzinBeallito(LokacioRTB);
                }

            }
            if (DatumDTP.Checked)//Csak a dátumot nézzük 
            {
                datum = DatumDTP.Value.ToString("yyyy-MM-dd");
                
                if (!(String.IsNullOrEmpty(where)))
                {
                    where += " AND ";
                }
                where += $"{OszlopNevek.Datum}='{datum}'";

            }
            if (CikkszamCBBX.SelectedIndex > -1)//Csak a cikkszámot nézzük
            {
                cikkszam = CikkszamCBBX.SelectedItem.ToString();

                
                if (!(String.IsNullOrEmpty(where)))
                {
                    where += " AND ";
                }
                where += $"{OszlopNevek.CikkID}='{cikkszam}'";
                

            }
            if (LokacioCBBX.SelectedIndex > -1)//Csak a lokációt nézzük
            {
                lokacio = LokacioCBBX.SelectedItem.ToString();
                
                if (!(String.IsNullOrEmpty(where)))
                {
                    where += " AND ";
                }
                where += $"{OszlopNevek.LokacioID}='{lokacio}'";
                
            }

            
            if (MindenKonyvelCHBX.Checked == false && KonyvelesFajtaCBBX.SelectedIndex == -1)
            {
                string uzenet = "Legalább egy könyvelési fajtát választania kell!";
                MessageBox.Show(uzenet, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (KonyvelesFajtaRTB.Text != "Könyvelés fajtája*")
                {
                    BetuSzinBeallito(KonyvelesFajtaRTB);
                }

            }
            if (KonyvelesFajtaCBBX.SelectedIndex > -1)
            {
                konyvelesFajta = KonyvelesFajtaCBBX.SelectedItem.ToString();
                where += $" AND {OszlopNevek.Komment}='{konyvelesFajta}'";
                lekerdezes.AddRange(Adatbazis.Info(where));
                
            }
            else if (MindenKonyvelCHBX.Checked == true)
            {
                where += " AND ";
                lekerdezes.AddRange(Adatbazis.Info(where + $"{OszlopNevek.Komment}='{AnyagmozgasKommentek.Betárolás}'"));
                lekerdezes.AddRange(Adatbazis.Info(where + $"{OszlopNevek.Komment}='{AnyagmozgasKommentek.Áttárolás_Innen}'"));
                lekerdezes.AddRange(Adatbazis.Info(where + $"{OszlopNevek.Komment}='{AnyagmozgasKommentek.Áttárolás_Ide}'"));
                lekerdezes.AddRange(Adatbazis.Info(where + $"{OszlopNevek.Komment}='{AnyagmozgasKommentek.Kiszállítás}'"));

            }
            if (lekerdezes.Count < 1)
            {
                string uzenet = "Nincs a keresésnek megfelelő eredmény!";
                MessageBox.Show(uzenet,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            BindingSource forras = new BindingSource();
            if (lekerdezes.Count > 1)
            {
                forras.ResetBindings(false);
            }
            forras.DataSource = lekerdezes;
            AdatokDGV.DataSource = forras;
            
        }
    }
}