using OnBarcode.Barcode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Cimkezes : Sablon
    {
        private string vallalat;
        private string datum = DateTime.Today.ToString("d");
        private static string cikkszam;
        private string vevoiCikkszam;
        private string megnevezes;
        private int darabszam;
        private int lokacio;
        private string megjegyzes;
        private int peldanySzam;
        public Cimkezes()
        {
            InitializeComponent();
            SetExitBtn(317,3);
            SetMinimalizeBtn(270,3);
        }


        protected override void SetExitBtn(int x, int y)
        {
            base.SetExitBtn(x,y);
        }

        protected override void SetMinimalizeBtn(int x, int y)
        {
            base.SetMinimalizeBtn(x, y);
        }

        private void CikkszamFeltoltes(object sender, EventArgs e)
        {
            ComboBox comboboxNeve = sender as ComboBox;
            List<string> lekerdezes = Adatbazis.Lekerdezes(TablaNevek.cikkek, OszlopNevek.CikkID);
            int elemekSzama = comboboxNeve.Items.Count;
            if (elemekSzama < lekerdezes.Count)
            {
                comboboxNeve.Items.AddRange(lekerdezes.ToArray());
            }
        }

        private void VevoiCikkFeltoltes(object sender, EventArgs e)
        {
            ComboBox comboboxNeve = sender as ComboBox;
            string cikkId = $"{OszlopNevek.CikkID}=" + (string)comboboxNeve.SelectedItem;
            string szoveg = Adatbazis.EgyAdatLekerese(TablaNevek.cikkek, OszlopNevek.VallalatCikk, cikkId);
            VevoiCikkTxtBox.Text = szoveg;
        }

        private void MegnevezesFeltolt(object sender, EventArgs e)
        {
            TextBox textBoxNeve = sender as TextBox;
            string vevoiCikkID = $"{OszlopNevek.VallalatCikk}=" + textBoxNeve.Text;
            string szoveg = Adatbazis.EgyAdatLekerese(TablaNevek.cikkek, OszlopNevek.VallalatMegjegyzes, vevoiCikkID);
            MegnTxtBox.Text = szoveg;
        }

        protected override void SzamEllenorzes(object sender, EventArgs e)
        {
            base.SzamEllenorzes(sender, e);
        }

        private void LokacioFeltoltes(object sender, EventArgs e)
        {
            ComboBox comboBoxNeve = sender as ComboBox;
            List<string> lekerdezes = Adatbazis.Lekerdezes(TablaNevek.raktar,OszlopNevek.LokacioID);
            lekerdezes.Sort();
            int elemekSzama = comboBoxNeve.Items.Count;
            if (elemekSzama < lekerdezes.Count)
            {
                comboBoxNeve.Items.AddRange(lekerdezes.ToArray());
            }
        }
        private void KepTorles()
        {
            string fileHelye = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] fileNevek = { "cikkszam.jpg", "vevoiCikkszam.jpg", "darabszam.jpg", "lokacio.jpg" };
            for (int i = 0; i < fileNevek.Length; i++)
            {
                if (File.Exists(fileHelye + fileNevek[i]))
                {
                    File.Delete(fileHelye + fileNevek[i]);
                }
            }
        }

        private void VonalkodGeneralas(string szoveg, string fileNeve)
        {
            Linear vonalkod = new Linear();
            vonalkod.Type = BarcodeType.CODABAR;
            vonalkod.Data = szoveg;
            vonalkod.drawBarcode(fileNeve);
        }

        private Image VonalkodMegjelenit(string fileNeve)
        {
            Image vonalkod = Image.FromFile(fileNeve);
            return vonalkod;
        }

        private void cimkeNyomtatas_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            KepTorles();
            Pen fekete = new Pen(Color.Black);
            string betuTipus = "Centuey Gothic";
            int betuMeret = 20;
            FontStyle betuStilus = FontStyle.Regular;
            Brush betuSzin = Brushes.Black;
            Font font = new Font(betuTipus, betuMeret, betuStilus);
            int lapSzelesseg = 825;
            int x = 0;
            int y = 0;
            int sorKoz = 50;
            int nagyTeglalapMagassag = 200;
            int kisTeglalapMagassag = 70;

            Rectangle teglalap = new Rectangle(x, y, lapSzelesseg, kisTeglalapMagassag);
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            string fileNeve;

            e.Graphics.DrawRectangle(fekete,teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Vevő", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(vallalat, new Font(betuTipus, betuMeret + 5, FontStyle.Bold), betuSzin, teglalap, stringFormat);
            y += kisTeglalapMagassag;

            teglalap = new Rectangle(x, y, lapSzelesseg, kisTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete,teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Dátum", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(datum, font, betuSzin, teglalap, stringFormat);
            y += kisTeglalapMagassag;

            teglalap = new Rectangle(x,y,lapSzelesseg, nagyTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete,teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            fileNeve = "cikkszam.jpg";
            e.Graphics.DrawString("Cikkszám", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(cikkszam, font, betuSzin, teglalap, stringFormat);
            VonalkodGeneralas(cikkszam, fileNeve);
            e.Graphics.DrawImage(VonalkodMegjelenit(fileNeve),(teglalap.Width /2) - 80 ,teglalap.Height + 20);
         
            teglalap = new Rectangle(x, y + (sorKoz * 4) , lapSzelesseg, nagyTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            fileNeve = "vevoiCikkszam.jpg";
            e.Graphics.DrawString("Vevői cikkszám", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(vevoiCikkszam, font, betuSzin, teglalap, stringFormat);
            VonalkodGeneralas(vevoiCikkszam, fileNeve);
            e.Graphics.DrawImage(VonalkodMegjelenit(fileNeve), (teglalap.Width / 2) - 70, 2 * teglalap.Height + 20);
            y += sorKoz * 8;

            teglalap = new Rectangle(x, y, lapSzelesseg, kisTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Megnevezés", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(megnevezes, font, betuSzin, teglalap, stringFormat);
            y += kisTeglalapMagassag;

            teglalap = new Rectangle(x, y, lapSzelesseg, nagyTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            fileNeve = "darabszam.jpg";
            e.Graphics.DrawString("Darabszám", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(darabszam +" db", font, betuSzin, teglalap, stringFormat);
            VonalkodGeneralas(darabszam + "", fileNeve);
            e.Graphics.DrawImage(VonalkodMegjelenit(fileNeve), (teglalap.Width / 2) - 50, 3 * teglalap.Height + 90);
            y += sorKoz * 4;

            teglalap = new Rectangle(x, y, lapSzelesseg, nagyTeglalapMagassag);
            e.Graphics.DrawRectangle(fekete, teglalap);
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            fileNeve = "lokacio.jpg";
            e.Graphics.DrawString("Lokáció", font, betuSzin, teglalap, stringFormat);
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(lokacio + "", font, betuSzin, teglalap, stringFormat);
            VonalkodGeneralas(lokacio + "", fileNeve);
            e.Graphics.DrawImage(VonalkodMegjelenit(fileNeve), (teglalap.Width / 2) - 55, 4 * teglalap.Height + 90);
            y += sorKoz * 4;
            
            if (!(String.IsNullOrEmpty(megjegyzes)))
            {
                teglalap = new Rectangle(x, y, lapSzelesseg, nagyTeglalapMagassag);
                e.Graphics.DrawRectangle(fekete, teglalap);
                stringFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString("Megjegyzés", font, betuSzin, teglalap, stringFormat);
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(megjegyzes, new Font(betuTipus, betuMeret + 5, FontStyle.Bold), betuSzin, teglalap, stringFormat);
            }
        }

        protected override void BetuSzinBeallito(object sender) 
        {
            base.BetuSzinBeallito(sender);
        }


        private void NyomtatasBtn_Click(object sender, EventArgs e)
        {
            bool vizsgalat = false;
            if (CikkszamCBox.SelectedIndex > -1 && !String.IsNullOrEmpty(DarabszTxtBox.Text) &&
                LokacioCBox.SelectedIndex > -1 && NyomtatottDB_NumUD.Value > 0)
            {
                vizsgalat = true;
                cikkszam = CikkszamCBox.SelectedItem.ToString();
                vevoiCikkszam = VevoiCikkTxtBox.Text;
                megnevezes = MegnTxtBox.Text;
                darabszam = int.Parse(DarabszTxtBox.Text);
                lokacio = int.Parse(LokacioCBox.SelectedItem.ToString());
                peldanySzam = Convert.ToInt32(NyomtatottDB_NumUD.Value);
                vallalat = Adatbazis.EgyAdatLekerese(TablaNevek.vallalat,OszlopNevek.VallalatNev,
                    Adatbazis.EgyAdatLekerese(TablaNevek.cikkek,
                                                OszlopNevek.VallalatID, 
                                                $"{OszlopNevek.CikkID}={cikkszam}"));

                if (!String.IsNullOrEmpty(MegjegyzTxtBox.Text))
                {
                    megjegyzes = MegjegyzTxtBox.Text;
                }
            }

            if (vizsgalat == true)
            {
                PrintDialog nyomtatas = new PrintDialog();
                nyomtatas.Document = new System.Drawing.Printing.PrintDocument();
                nyomtatas.Document.PrinterSettings.Copies = Convert.ToInt16(peldanySzam);
                printPreviewDialog1.Document.PrinterSettings.Copies = Convert.ToInt16(peldanySzam);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    cimkeNyomtatas.Print();
                }
                CikkszamCBox.Items.Clear();
                VevoiCikkTxtBox.Clear();
                MegnTxtBox.Clear();
                DarabszTxtBox.Clear();
                LokacioCBox.Items.Clear();
                MegjegyzTxtBox.Clear();
            }
            else
            {
                string uzenet = "A *-gal jelzett mezők kitöltése kötelező!";
                if (CikkszamRTB.Text != "Cikkszám*")
                {
                    BetuSzinBeallito(CikkszamRTB);
                    BetuSzinBeallito(DarabszamRTB);
                    BetuSzinBeallito(LokacioRTB);
                    BetuSzinBeallito(NyomtatottDb_RTB);
                }
                MessageBox.Show(uzenet,"Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}

