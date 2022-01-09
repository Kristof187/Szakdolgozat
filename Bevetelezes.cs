using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Bevetelezes : Sablon
    {
         private string datum;
         private int szallitoSzam;
         private int cikkID;
         private int darabszam;
         private int lokacioID;

         public string GetDatum() { return datum; }
         public int GetSzallitoSzam() { return szallitoSzam; }
         public int GetCikkID() { return cikkID; }
         public int GetDarabszam() { return darabszam; }
         public int GetLokacioID() { return lokacioID; }

         public Bevetelezes(string datum, int szallitoSzam, int cikkId, int darabszam, int lokacioID)
         {
             this.datum = datum;
             this.szallitoSzam = szallitoSzam;
             this.cikkID = cikkId;
             this.darabszam = darabszam;
             this.lokacioID = lokacioID;
         }

         public Bevetelezes(string datum, int cikkId, int darabszam, int lokacioID)
         {
             this.datum = datum;
             this.cikkID = cikkId;
             this.darabszam = darabszam;
             this.lokacioID = lokacioID;
         }

         public Bevetelezes()
         {
             InitializeComponent();
         }

         //A táblázatos kialakítás miatt egyszerűbb volt minden mezőt feltölteni a saját metódusába
         private DateTimePicker[] Datumok()
         {
             DateTimePicker[] datumok = { datum1, datum2, datum3, datum4, datum5, datum6, datum7, datum8, datum9, datum10, datum11, datum12, datum13 };
             return datumok;
         }

         private TextBox[] Szallitok()
         {
             TextBox[] szallitok = { szallito1, szallito2, szallito3, szallito4, szallito5, szallito6, szallito7, szallito8, szallito9, szallito10,
                 szallito11, szallito12, szallito13 };
             return szallitok;
         }

         private ComboBox[] Cikkek()
         {
             ComboBox[] cikkek = { cikkszam1, cikkszam2, cikkszam3, cikkszam4, cikkszam5, cikkszam6, cikkszam7, cikkszam8, cikkszam9, cikkszam10,
                 cikkszam11, cikkszam12, cikkszam13 };
             return cikkek;
         }

         private TextBox[] VevoiCikkek()
         {
             TextBox[] vevoiCikkek = { vevoiCikkszam1, vevoiCikkszam2, vevoiCikkszam3, vevoiCikkszam4, vevoiCikkszam5, vevoiCikkszam6, vevoiCikkszam7,
                 vevoiCikkszam8, vevoiCikkszam9, vevoiCikkszam10, vevoiCikkszam11, vevoiCikkszam12, vevoiCikkszam13 };
             return vevoiCikkek;
         }

         private TextBox[] Darabszamok()
         {
             TextBox[] darabszamok = { darabszam1, darabszam2, darabszam3, darabszam4, darabszam5, darabszam6, darabszam7, darabszam8, darabszam9,
                 darabszam10, darabszam11, darabszam12, darabszam13 };
             return darabszamok;
         }

         private ComboBox[] Lokaciok()
         {
             ComboBox[] lokaciok = { lokacio1, lokacio2, lokacio3, lokacio4, lokacio5, lokacio6, lokacio7, lokacio8, lokacio9, lokacio10, lokacio11,
                 lokacio12, lokacio13 };
             return lokaciok;
         }

         //Megjeleníti a dátumot és az aktuális dateTimePicker-nél a checked -et true -ra állítja
         private void DatumKivalaszt(object sender, EventArgs e)
         {
             DateTimePicker datumNeve = sender as DateTimePicker;
             datumNeve.Format = DateTimePickerFormat.Short;
             datumNeve.Checked = true;
         }

         //Feltölti a cikkszám comboboxokat
         private void CikkszamFeltoltes(object sender, EventArgs e)
         {
             ComboBox comboboxNeve = sender as ComboBox;
            //List<string> lekerdezes = Adatbazis.Lekerdezes("cikkek", "CikkID", "VallalatMegjegyzes");
            List<string> lekerdezes = Adatbazis.Lekerdezes(TablaNevek.cikkek, OszlopNevek.CikkID, OszlopNevek.VallalatMegjegyzes);
            int elemekSzama = comboboxNeve.Items.Count;
             if (elemekSzama < lekerdezes.Count)
             {
                 comboboxNeve.Items.AddRange(lekerdezes.ToArray());
             }
         }

         //Feltölti a vevői cikkszám textboxokat az alapján amit választunk a cikkszám mezőben
         private void VevoiCikkFeltolt(object sender, EventArgs e)
         {
             ComboBox comboboxNeve = sender as ComboBox;
             string cikkId = (string)comboboxNeve.SelectedItem;
             string kereses = $"{OszlopNevek.CikkID}=" + cikkId.Remove(9);
             string szoveg = Adatbazis.EgyAdatLekerese(TablaNevek.cikkek, OszlopNevek.VallalatCikk, kereses);
             string sor = comboboxNeve.Name;

             ComboBox[] cikkek = Cikkek();
             TextBox[] vevoiCikkek = VevoiCikkek();
             int i = 0;
             while (i < vevoiCikkek.Length)
             {

                 if (sor == cikkek[i].Name)
                 {
                     vevoiCikkek[i].Text = szoveg;
                 }
                 i++;
             }
         }

         //Ellenőrzi mit írtunk a darabszám mezőbe, csak számokat fogad el, a nullát sem fogadja el
         protected override void SzamEllenorzes(object sender, EventArgs e)
         {
            base.SzamEllenorzes(sender, e);
         }
         private void SzallitoEllenorzes(object sender, EventArgs e)
         {
             TextBox textBoxNeve = sender as TextBox;
             textBoxNeve.TextChanged += new EventHandler(SzamEllenorzes);
             string where = $"{OszlopNevek.SzallitoSzam} IS NOT NULL";
             List<string> szallitoSzamok = Adatbazis.Kereses(TablaNevek.anyagmozgas, OszlopNevek.SzallitoSzam, where);
             int i = 0;
             while (i < szallitoSzamok.Count)
             {
                 if (textBoxNeve.Text == szallitoSzamok[i])
                 {
                     MessageBox.Show($"Már létező szállítólevél szám!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     textBoxNeve.Clear();
                 }
                 i++;
             }
         }

         //ellenőrizni kell a lokációkat csak olyat töltsön fel ahol egyeznek a cikkszámok, különben az első felülírja a másodikat!
         //Feltölti a lokációkat, csak azokat a lokációkat tölti fel amik "üresek" (nincs semmi oda tárolva)
         private void LokacioFeltoltes(object sender, EventArgs e)
         {
            ComboBox comboboxNeve = sender as ComboBox;
            ComboBox[] box = Lokaciok();
            List<string> torlendoLokaciok = new List<string>();
            int i = 0;
            while (box.Length > i)
            {
                if (box[i].SelectedIndex != -1)
                {
                    torlendoLokaciok.Add(box[i].SelectedItem.ToString());
                }
                i++;
            }
             List<string> lokaciok = Adatbazis.Lekerdezes(TablaNevek.raktar, OszlopNevek.LokacioID);
             string where = $"{OszlopNevek.CikkID} IS NULL";
             List<string> feltoltottLokaciok = Adatbazis.Kereses(TablaNevek.raktar, OszlopNevek.LokacioID, where);

            int j = 0;
            while (torlendoLokaciok.Count > j)
            {
                feltoltottLokaciok.Remove(torlendoLokaciok[j]);
                j++;
            }

             int elemekSzama = comboboxNeve.Items.Count;
             if (elemekSzama < feltoltottLokaciok.Count)
             {
                 comboboxNeve.Items.AddRange(feltoltottLokaciok.ToArray());
             }
        }

        protected override void BetuSzinBeallito(object sender)
        {
            base.BetuSzinBeallito(sender);
        }

        public static List<Bevetelezes> betarolas = new List<Bevetelezes>();

         //Tömbbe szerveztem minden adatot így ha egy ciklussal végigtekerünk rajtuk akkor mindig az aktuális sort fogja nézni
         internal void bevetelezesBtn_Click(object sender, EventArgs e)
         {
             DateTimePicker[] datumok = Datumok();
             TextBox[] szallitok = Szallitok();
             ComboBox[] cikkek = Cikkek();
             TextBox[] vevoiCikkek = VevoiCikkek();
             TextBox[] darabszamok = Darabszamok();
             ComboBox[] lokaciok = Lokaciok();

             bool vizsgalat = false;
             int i = 0;
             while (i < datumok.Length)
             {
                 //ha a dátum checked && cikkekből egy elem ki lett választva && vevoiCikkek NEM üres && darabszamok NEM üres && lokaciokból egy elem ki lett választva
                 if (datumok[i].Checked && cikkek[i].SelectedIndex > -1 && (!String.IsNullOrEmpty(vevoiCikkek[i].Text)) &&
                     (!String.IsNullOrEmpty(darabszamok[i].Text)) && lokaciok[i].SelectedIndex > -1)
                 {
                     vizsgalat = true;
                     string datum = datumok[i].Value.ToString("yyyy-MM-dd");
                     int cikk = int.Parse(cikkek[i].Text.Remove(9));
                     int darabszam = int.Parse(darabszamok[i].Text);
                     int lokacio = int.Parse(lokaciok[i].Text);

                     if (!(String.IsNullOrEmpty(szallitok[i].Text)))
                     {
                         int szallito = int.Parse(szallitok[i].Text);
                         betarolas.Add(new Bevetelezes(datum, szallito, cikk, darabszam, lokacio));
                         Adatbazis.Betarolas(i);
                         Adatbazis.BevetelezesLokaciora(i);
                     }
                     else
                     {
                         betarolas.Add(new Bevetelezes(datum, cikk, darabszam, lokacio));
                         Adatbazis.Betarolas(i);
                         Adatbazis.BevetelezesLokaciora(i);
                     }

                     datumok[i].Format = DateTimePickerFormat.Custom;
                     datumok[i].Checked = false;
                     szallitok[i].Clear();
                     cikkek[i].Items.Clear();
                     vevoiCikkek[i].Clear();
                     darabszamok[i].Clear();
                     lokaciok[i].Items.Clear();

                 }
                 i++;
             }
             if (vizsgalat)
             {
                 MessageBox.Show("Sikeres bevételezés", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                string uzenet = "A *-gal jelzett mezők kitöltése kötelező!";
                if (DatumRTB.Text != "Dátum*")
                {
                    BetuSzinBeallito(DatumRTB);
                    BetuSzinBeallito(CikkszamRTB);
                    BetuSzinBeallito(darabszamRTB);
                    BetuSzinBeallito(lokacioRTB);
                }
                MessageBox.Show(uzenet, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

