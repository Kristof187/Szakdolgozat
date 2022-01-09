using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Attarolas : Sablon
    {
        public Attarolas()
        {
            InitializeComponent();
        }

        //Csak azokat a lokációkat töltöm fel comboboxba ahol van is valami (a raktar-> CikkID IS NOT NULL)
        private void RegiLokacioFeltolt(object sender, EventArgs e)
        {
            ComboBox comboBoxNeve = sender as ComboBox;
            List<string> kereses = Adatbazis.Kereses(TablaNevek.raktar,OszlopNevek.LokacioID,$"{OszlopNevek.CikkID} IS NOT NULL");
            kereses.Sort();
            int elemekSzama = comboBoxNeve.Items.Count;
            if (elemekSzama < kereses.Count)
            {
                comboBoxNeve.Items.AddRange(kereses.ToArray());
            }
        }

        protected override void SzamEllenorzes(object sender, EventArgs e)
        {
            base.SzamEllenorzes(sender, e);
        }

        private void AdatokFeltoltes(object sender, EventArgs e)
        {
            ComboBox valasztott = sender as ComboBox;
            string valasztottLokacio = valasztott.SelectedItem.ToString();
            string cikk_A_Lokacion = Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.CikkID, $"{OszlopNevek.LokacioID}={valasztottLokacio}");
            CikkszamLbl.Text = "Cikkszám: " + cikk_A_Lokacion;
            string vallalatID = Adatbazis.EgyAdatLekerese(TablaNevek.cikkek,OszlopNevek.VallalatID,$"{OszlopNevek.CikkID}={cikk_A_Lokacion}");
            VevoLbl.Text = "Vevő: " + Adatbazis.EgyAdatLekerese(TablaNevek.vallalat,OszlopNevek.VallalatNev,$"{OszlopNevek.VallalatID}={vallalatID}");
            VevoiCikkLbl.Text = "Vevői cikkszám: " + Adatbazis.EgyAdatLekerese(TablaNevek.cikkek, OszlopNevek.VallalatCikk, $"{OszlopNevek.CikkID}={cikk_A_Lokacion}");
            MegnevLbl.Text = "Megnevezés: " + Adatbazis.EgyAdatLekerese(TablaNevek.cikkek, OszlopNevek.VallalatMegjegyzes,$"{OszlopNevek.CikkID}={cikk_A_Lokacion}");
            DarabszamLbl.Text = "Darabszám: " + Adatbazis.EgyAdatLekerese(TablaNevek.raktar,OszlopNevek.Darabszam,$"{OszlopNevek.LokacioID}={valasztottLokacio}");
        }

        private void TeljesMennyCHB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox teljesMennyiseg = sender as CheckBox;
            if (teljesMennyiseg.Checked && RegiLokacioCBX.SelectedIndex > -1)
            {
                string where = $"{OszlopNevek.LokacioID}={RegiLokacioCBX.SelectedItem}";
                string darabszam = Adatbazis.EgyAdatLekerese(TablaNevek.raktar,OszlopNevek.Darabszam,where);
                DarabszamTXB.Text = darabszam;
            }
            if (teljesMennyiseg.Checked == false)
            {
                DarabszamTXB.Clear();
            }
        }

        private void RegiLokacioCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            DarabszamTXB.Clear();
            TeljesMennyCHB.Checked = false;
            if (AzonosRBT.Checked == true)
            {
                uresRBT.Checked = true;
                AzonosRBT.Checked = false;
            }
            UjLokacioCBX.Text = "";
            UjLokacioCBX.Items.Clear();
            UjLokCikkLbl.Text = "Cikkszám: ";
            UjLokDbLbl.Text = "Darabszám: ";
        }

        private void UjLokacioAdatokFeltolt()
        {
            string lokacio = UjLokacioCBX.SelectedItem.ToString();
            UjLokCikkLbl.Text = "Cikkszám: " + Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.CikkID, $"{OszlopNevek.LokacioID}={lokacio}");
            UjLokDbLbl.Text = "Darabszám: " + Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={lokacio}");
        }

        private void UjLokacioFeltoltes(object sender, EventArgs e)
        {
            UjLokacioCBX.Items.Clear();

            List<string> kereses = new List<string>();
            if (uresRBT.Checked == true)
            {
                kereses = Adatbazis.Kereses(TablaNevek.raktar, OszlopNevek.LokacioID, $"{OszlopNevek.CikkID} IS NULL");
            }
            if (AzonosRBT.Checked == true)
            {
                string regiLokacio = RegiLokacioCBX.SelectedItem.ToString();
                string where = Adatbazis.EgyAdatLekerese(TablaNevek.raktar,OszlopNevek.CikkID,$"{OszlopNevek.LokacioID}={regiLokacio}");
                kereses = Adatbazis.Kereses(TablaNevek.raktar, OszlopNevek.LokacioID, $"{OszlopNevek.CikkID}={where}");
                kereses.Remove(regiLokacio);
            }
            kereses.Sort();
            int elemekSzama = UjLokacioCBX.Items.Count;
            if (elemekSzama < kereses.Count)
            {
                UjLokacioCBX.Items.AddRange(kereses.ToArray());
            }
        }

        private void UjLokacioCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AzonosRBT.Checked == true)
            {
                UjLokacioAdatokFeltolt();
            }
        }

        protected override void BetuSzinBeallito(object sender)
        {
            base.BetuSzinBeallito(sender);
        }

        private void AdatokTorlese(object sender, EventArgs e)
        {
            RegiLokacioCBX.Text = "";
            RegiLokacioCBX.Items.Clear();
            VevoLbl.Text = "Vevő: ";
            CikkszamLbl.Text = "Cikkszám: ";
            VevoiCikkLbl.Text = "Vevői cikkszám: ";
            MegnevLbl.Text = "Megnevezés: ";
            DarabszamLbl.Text = "Darabszám: ";
            RegiLokacioCBX_SelectedIndexChanged(sender, e);
        }

        private void AttarolasBtn_Click(object sender, EventArgs e)
        {
            if (RegiLokacioCBX.SelectedIndex > -1 && int.Parse(DarabszamTXB.Text) > 0 && UjLokacioCBX.SelectedIndex > -1)
            {
                int regiTarhely = int.Parse(RegiLokacioCBX.SelectedItem.ToString());
                string cikk = Adatbazis.EgyAdatLekerese(TablaNevek.raktar,OszlopNevek.CikkID, $"{OszlopNevek.LokacioID}={regiTarhely}");
                int db = int.Parse(DarabszamTXB.Text);
                int ujTarhely = int.Parse(UjLokacioCBX.SelectedItem.ToString());

                int darab;
                //ez felel azért hogy ha au úl lokáción van valami akkor azt adja hozzá a darabszámhoz és úgy UPDATE elje
                if (Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={ujTarhely}") != null)
                {
                    darab = db + int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={ujTarhely}"));
                }
                else { darab = db; }

                Adatbazis.AttarolasIde(cikk,db + "",ujTarhely + "");
                Adatbazis.AttarolasLokaciora(ujTarhely, cikk, darab); //ez tárol az új lokációra

                //ez felel azért hogy ha a régi lokációról nem könyvelünk át mindent akkor a maradék maradjon a régi lokáción
                int eredetiDarabszam = int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={regiTarhely}"));
                if (eredetiDarabszam == db)
                {
                    Adatbazis.SetLokacioNull(null,regiTarhely +""); //ha mindet áttároljuk akkor a régi lokáció legyen null 
                }
                else
                {
                    darab = eredetiDarabszam - db;
                    Adatbazis.AttarolasLokaciora(regiTarhely, cikk, darab);
                    //ha a lokáción lévő mennyiségnek csak egy részét tároljuk át akkor ki kell vonni belőle az áttárolt darabot a régiLokáción
                }
                Adatbazis.AttarolasInnen(cikk, db + "", regiTarhely + "");
                string uzenet = "Sikeres áttárolás!";
                MessageBox.Show(uzenet,"",MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdatokTorlese(sender,e);
            }
            else
            {
                string uzenet = "A *-gal jelzett mezők kitöltése kötelező!";
                BetuSzinBeallito(LokacioRTB);
                BetuSzinBeallito(DbSzovegRBT);
                BetuSzinBeallito(UjLokacioRBT);

                MessageBox.Show(uzenet, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
