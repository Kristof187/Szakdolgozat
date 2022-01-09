using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Kiszallitas : Sablon
    {
        private void DataGridViewBeallitas()
        {
            AdatokDGV.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            AdatokDGV.DefaultCellStyle.ForeColor = Color.Black;
            AdatokDGV.DefaultCellStyle.BackColor = Color.White;
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Sor törlése";
            deleteButton.Text = "Törlés";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 150;
            AdatokDGV.Columns.Add(deleteButton);
        }
        public Kiszallitas()
        {
            InitializeComponent();
            DataGridViewBeallitas();
        }

        public List<Komissiozas> komissiozas = new List<Komissiozas>();

        private void AddKomissiozas(string vevo, string cikkszam, string darabszam)
        {
            komissiozas.Add(new Komissiozas() { vevo = vevo,cikkszam = cikkszam, darabszam = darabszam});
        }

        private void VevoFeltolt(object sender, EventArgs e)
        {
            ComboBox comboBoxNeve = sender as ComboBox;
            List<string> kereses = Adatbazis.Lekerdezes(TablaNevek.vallalat, OszlopNevek.VallalatNev);
            kereses.Sort();
            int elemekSzama = comboBoxNeve.Items.Count;
            if (elemekSzama < kereses.Count)
            {
                comboBoxNeve.Items.AddRange(kereses.ToArray());
            }
        }

        private void CikkszamFeltolt(object sender, EventArgs e)
        {
            CikkszamCBBX.Items.Clear();
            string vallalatNev = VevoCBBX.SelectedItem.ToString();
            string vallalatID = Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatID, $"{OszlopNevek.VallalatNev}='{vallalatNev}'");
            List<string> kereses = Adatbazis.Kereses(TablaNevek.cikkek, OszlopNevek.CikkID, $"{OszlopNevek.VallalatID}={vallalatID}");
            kereses.Sort();
            int elemekSzama = CikkszamCBBX.Items.Count;
            if (elemekSzama < kereses.Count)
            {
                CikkszamCBBX.Items.AddRange(kereses.ToArray());
            }
        }

        protected override void SzamEllenorzes(object sender, EventArgs e)
        {
            base.SzamEllenorzes(sender, e);
        }

        protected override void BetuSzinBeallito(object sender)
        {
            base.BetuSzinBeallito(sender);
        }

        private bool DarabszamEllenorzese(string cikkszam, string darabszam) 
        {
            bool vizsgalat = false;
            List<string> lokaciok = Adatbazis.Kereses(TablaNevek.raktar,OszlopNevek.LokacioID,$"{OszlopNevek.CikkID}={cikkszam}");
            int osszDarabszam = 0;
            int i = 0;
            while (lokaciok.Count > i)
            {
                osszDarabszam += int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.raktar,OszlopNevek.Darabszam,$"{OszlopNevek.LokacioID}={lokaciok[i]}"));
                i++;
            }
            if (osszDarabszam >= int.Parse(darabszam))
            {
                vizsgalat = true;
            }
            return vizsgalat;
        }

        private void FelvetelBTN_Click(object sender, EventArgs e)
        {
            if (VevoCBBX.SelectedIndex > -1 && CikkszamCBBX.SelectedIndex > -1 && !(String.IsNullOrEmpty(DarabszamTXB.Text)))
            {
                string vevo = VevoCBBX.SelectedItem.ToString();
                string cikkszam = CikkszamCBBX.SelectedItem.ToString();
                string darabszam = DarabszamTXB.Text;

                if (DarabszamEllenorzese(cikkszam,darabszam) == true)
                {
                    AddKomissiozas(vevo, cikkszam, darabszam);
                    BindingSource forras = new BindingSource();
                    if (komissiozas.Count > 1)
                    {
                        forras.ResetBindings(false);
                    }
                    forras.DataSource = komissiozas;
                    AdatokDGV.DataSource = forras;
                }
                else
                {
                    string hibaUzenet = $"Nincs ennyi darab az alábbi cikkszámból:\n {cikkszam}";
                    MessageBox.Show(hibaUzenet, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                CikkszamCBBX.Text = "";
                CikkszamCBBX.SelectedIndex = -1;
                DarabszamTXB.Clear();
            }
            else if (komissiozas.Count > 0 && !(String.IsNullOrEmpty(DarabszamTXB.Text)))
            {
                if (VevoCBBX.SelectedItem.ToString() != komissiozas[0].vevo)
                {
                    string uzenet = "Nem lehet más a vevő!";
                    BetuSzinBeallito(VevoRTB);
                    MessageBox.Show(uzenet,"Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if (VevoRTB.Text != "Vevő*" || CikkszamRTB.Text != "Cikkszám*")
                {
                    BetuSzinBeallito(VevoRTB);
                    BetuSzinBeallito(CikkszamRTB);
                    BetuSzinBeallito(DarabszamRTB);
                }
                
                string uzenet = "A *-gal jelölt mezők kitöltése kötelező!";
                MessageBox.Show(uzenet,"Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AdatokDGV_SorTorlese(object sender, DataGridViewCellEventArgs e)
        {
            int aktualisSor = e.RowIndex;

            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (AdatokDGV.Columns[e.ColumnIndex].HeaderText == "Sor törlése" && aktualisSor >= 0)
            {
                AdatokDGV.Rows.RemoveAt(aktualisSor);
                int torlendoSor = aktualisSor - 1;
                if (torlendoSor >= 0)
                {
                    komissiozas[torlendoSor].vevo.Remove(0, komissiozas[torlendoSor].vevo.Length);
                    komissiozas[torlendoSor].cikkszam.Remove(0, komissiozas[torlendoSor].cikkszam.Length);
                    komissiozas[torlendoSor].darabszam.Remove(0, komissiozas[torlendoSor].darabszam.Length);
                }
            }
        }

        private void printKomissiozas_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<FIFO> kiszedes = Komissiozas.GetKiszedes();
            Pen atlatszo = new Pen(Color.Transparent);
            Pen fekete = new Pen(Color.Black);
            string betuTipus = "Centuey Gothic";
            int betuMeret = 20;
            FontStyle betuStilus = FontStyle.Regular;
            Brush betuSzin = Brushes.Black;
            Font font = new Font(betuTipus, betuMeret, betuStilus);
            int lapSzelesseg = 825;
            int lapMagassag = 1100;
            int x = 0;
            int y = 0;
            int sorKoz = 50;

            Rectangle teglalap;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            int i = 0;
            while (kiszedes.Count > i)
            {
                if (y == 0 || y % lapMagassag == 0)
                {
                    stringFormat.Alignment = StringAlignment.Center;
                    teglalap = new Rectangle(x,y,lapSzelesseg,sorKoz);
                    e.Graphics.DrawRectangle(fekete, teglalap);
                    e.Graphics.DrawString("Komissiózás", new Font(betuTipus, betuMeret + 5, FontStyle.Bold), betuSzin, teglalap, stringFormat);
                    y += sorKoz;

                    teglalap = new Rectangle(x, y, lapSzelesseg, sorKoz);
                    e.Graphics.DrawRectangle(fekete, teglalap);
                    stringFormat.Alignment = StringAlignment.Near;
                    e.Graphics.DrawString("Cikkszám", font, betuSzin, teglalap, stringFormat);
                    stringFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString("Lokáció", font, betuSzin, teglalap, stringFormat);
                    stringFormat.Alignment = StringAlignment.Far;
                    e.Graphics.DrawString("Darabszám", font, betuSzin, teglalap, stringFormat);
                    y += sorKoz;

                }
                teglalap = new Rectangle(x, y, lapSzelesseg, sorKoz);
                e.Graphics.DrawRectangle(atlatszo, teglalap);


                stringFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(kiszedes[i].cikkszam, font, betuSzin, teglalap, stringFormat);
                stringFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(kiszedes[i].lokacio, font, betuSzin, teglalap, stringFormat);
                stringFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(kiszedes[i].darabszam, font, betuSzin, teglalap, stringFormat);
                e.Graphics.DrawLine(fekete, x, y + (sorKoz - 10), lapSzelesseg, y + (sorKoz - 10));
                y += sorKoz;
                if (y >= lapMagassag)
                {
                    e.HasMorePages = true;
                }
                i++;
            }
            Komissiozas.SetKiszedes();
        }
        bool komissiozasVizsgalat = false;

        List<FIFO> kiszallitas = new List<FIFO>();

        private void KomissioListaBTN_Click(object sender, EventArgs e)
        {
            Komissiozas.SetKiszedes();

            if (Komissiozas.AutomataKomissio(komissiozas) == false && AdatokDGV.Rows.Count > 0)
            {
                string hiba = "Nincs elég darab a következő anyag(ok)ból: ";
                int i = 0;
                List<string> hibasCikkszamok = Komissiozas.DarabszamHiba();
                if (hiba == "Nincs elég darab a következő anyag(ok)ból: ")
                {
                    while (hibasCikkszamok.Count > i)
                    {
                        hiba = hiba + hibasCikkszamok[i] + " ";
                        i++;
                    }
                }
                
                MessageBox.Show(hiba, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hibasCikkszamok.Clear();
            }
            else if (AdatokDGV.Rows.Count == 0)
            {
                string uzenet = "Vegyen fel valamit a táblázatba!";
                MessageBox.Show(uzenet,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                komissiozasVizsgalat = true;
                Komissiozas.GetKiszedes();
                kiszallitas.AddRange(Komissiozas.GetKiszedes());
                if (printPreviewKomissiozas.ShowDialog() == DialogResult.OK)
                {
                    printKomissiozas.Print();
                }

            }
            printKomissiozas = new PrintDocument();
        }

        private int SzallitoLevelSzam()
        {
            string utolsoSzallitoSzam = Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.SzallitoSzam, $"{OszlopNevek.Komment}='{AnyagmozgasKommentek.Kiszállítás}'");
            int ujSzallitoSzam;
            if (utolsoSzallitoSzam == null)
            {
                utolsoSzallitoSzam = "1000";
                ujSzallitoSzam = int.Parse(utolsoSzallitoSzam);
            }
            else
            {
                ujSzallitoSzam = int.Parse(utolsoSzallitoSzam) + 1;
            }
            
            return ujSzallitoSzam;
        }

        private void printSzallito_PrintPage(object sender, PrintPageEventArgs e)
        {
            List<Komissiozas> lista = Komissiozas.GetSzallitoLevel();
            Pen atlatszo = new Pen(Color.Transparent);
            Pen fekete = new Pen(Color.Black);
            string betuTipus = "Centuey Gothic";
            int betuMeret = 15;
            FontStyle betuStilus = FontStyle.Regular;
            Brush betuSzin = Brushes.Black;
            Font font = new Font(betuTipus, betuMeret, betuStilus);
            int lapSzelesseg = 825;
            int x = 0;
            int y = 0;
            int sorKoz = 50;

            Rectangle teglalap = new Rectangle(x, y, lapSzelesseg, sorKoz);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawRectangle(fekete, teglalap);
            e.Graphics.DrawString("Szállítólevél", new Font(betuTipus, betuMeret + 10, FontStyle.Bold), betuSzin, teglalap, stringFormat);
            y += sorKoz;

            teglalap = new Rectangle(x,y,lapSzelesseg / 2,sorKoz * 4);
            e.Graphics.DrawRectangle(fekete,teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            string kibocsato = $"Kibocsátó neve, címe: \n\r\n { Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatNev, $"{OszlopNevek.VallalatID}={1}")}" +
                $" \r\n {Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatCim, $"{OszlopNevek.VallalatID}={1}")}";
            e.Graphics.DrawString(kibocsato, font, betuSzin, teglalap, stringFormat);

            stringFormat.LineAlignment = StringAlignment.Far;
            string kibocsatoAdatok = $"Elérhetőségek: \r\n {Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatEmail, $"{OszlopNevek.VallalatID}={1}")}" +
                $" \r\n +{Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatTelefon, $"{OszlopNevek.VallalatID}={1}")}";
            e.Graphics.DrawString(kibocsatoAdatok, font, betuSzin, teglalap, stringFormat);

            teglalap = new Rectangle(lapSzelesseg / 2 ,y,lapSzelesseg / 2, sorKoz * 4);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            string vevo = $"Vevő neve, címe: \n\r\n {lista[0].vevo}\r\n {Adatbazis.EgyAdatLekerese(TablaNevek.vallalat,OszlopNevek.VallalatCim, $"{OszlopNevek.VallalatNev}='{lista[0].vevo}'")}";
            e.Graphics.DrawString(vevo, font, betuSzin, teglalap, stringFormat);

            stringFormat.LineAlignment = StringAlignment.Far;
            string vevoAdatok = $"Elérhetőségek: \r\n {Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatEmail, $"{OszlopNevek.VallalatNev}='{lista[0].vevo}'")}" +
                $" \r\n +{Adatbazis.EgyAdatLekerese(TablaNevek.vallalat, OszlopNevek.VallalatTelefon, $"{OszlopNevek.VallalatNev}='{lista[0].vevo}'")}";
            e.Graphics.DrawString(vevoAdatok, font, betuSzin, teglalap, stringFormat);
            y += sorKoz * 4;

            teglalap = new Rectangle(x,y,lapSzelesseg,sorKoz);
            e.Graphics.DrawRectangle(fekete,teglalap);

            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString($"Szállítólevél Szám: {(SzallitoLevelSzam() -1) + ""}",font,betuSzin,teglalap,stringFormat);
            stringFormat.Alignment = StringAlignment.Far;
            e.Graphics.DrawString($"Kiállítás dátuma: {DateTime.Now}",font,betuSzin,teglalap,stringFormat);
            y += sorKoz;

            teglalap = new Rectangle(x, y, lapSzelesseg, sorKoz);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Cikkszám", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("Megnevezés", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Darabszám", font, betuSzin, teglalap, stringFormat);
            y += sorKoz;

            int i = 0;
            int hossz = lista.Count;
            string cikkszamok = "";
            string megnevezesek = "";
            string darabszamok = "";
            while (hossz > i)
            {
                cikkszamok += lista[i].cikkszam + " \r\n";
                megnevezesek += Adatbazis.EgyAdatLekerese(TablaNevek.cikkek,OszlopNevek.VallalatMegjegyzes, $"{OszlopNevek.CikkID}={lista[i].cikkszam}") + "\r\n";
                darabszamok += lista[i].darabszam + "\r\n";
                i++;
            }

            teglalap = new Rectangle(x,y,lapSzelesseg,(hossz*sorKoz)/2);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(cikkszamok, font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(megnevezesek, font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(darabszamok, font, betuSzin, teglalap, stringFormat);
            y += (hossz * sorKoz)/2;

            teglalap = new Rectangle(x,y,lapSzelesseg/2,sorKoz * 3);
            e.Graphics.DrawRectangle(atlatszo,teglalap);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawLine(fekete,137,y+(sorKoz*2),275,y+(sorKoz*2));
            e.Graphics.DrawString("Átadó",font,betuSzin,teglalap,stringFormat);

            teglalap = new Rectangle(lapSzelesseg /2,y,lapSzelesseg /2,sorKoz *3);
            e.Graphics.DrawRectangle(atlatszo,teglalap);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawLine(fekete, 550, y + (sorKoz * 2), 687, y + (sorKoz * 2));
            e.Graphics.DrawString("Átvevő", font, betuSzin, teglalap, stringFormat);
            Komissiozas.SetSzallitoLevel();
        }

        bool komissiozasBtnVizsgalat = false;
        private void KomissiozasBTN_Click(object sender, EventArgs e)
        {
            if (komissiozasVizsgalat == true)
            {
                Adatbazis.Kiszallitas(kiszallitas, SzallitoLevelSzam() + "");
                Adatbazis.KiszallitasRaktar(kiszallitas);
                string uzenet = "Sikeres Komissiózás!";
                MessageBox.Show(uzenet, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdatokDGV.Rows.Clear();
                AdatokDGV.Refresh();
                komissiozasBtnVizsgalat = true;
            }
            else
            {
                string hibauzenet = "Elöször a komissiozas listát kell kinyomtatnia!";
                MessageBox.Show(hibauzenet,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void SzallitoBTN_Click(object sender, EventArgs e)
        {
            if (komissiozasBtnVizsgalat == true)
            {   
                if (printPreviewSzallito.ShowDialog() == DialogResult.OK)
                {
                    printSzallito.Print();
                }
            }
            else
            {
                string hibaUzenet = "Elöbb Komissióznia kell!";
                MessageBox.Show(hibaUzenet,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        } 
    }
}