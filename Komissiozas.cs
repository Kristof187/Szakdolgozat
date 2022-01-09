using System;
using System.Collections.Generic;

namespace Szakdolgozat
{
    public class Komissiozas
    {
        public string vevo { get; set; }
        public string cikkszam { get; set; }
        public string darabszam { get; set; }

        private void SetDarabszam(string darabszam) { this.darabszam = darabszam; }

        static List<Komissiozas> ellenorzottKomissiozas = new List<Komissiozas>();

        static List<Komissiozas> szallitoLevel = new List<Komissiozas>();

        //Kiválogatás tételével megnézem van e benne azonos cikkszám
        internal static void ListaEllenorzes(List<Komissiozas> komissiozas)
        {
            List<int> tobbszorSzereploIndexek = new List<int>();
            int i = 0;
            int j = 0;
            while (komissiozas.Count > i && komissiozas.Count > 1)
            {
                //megnézi melyik indexen van a két azonos cikkszám
                if (komissiozas[i].cikkszam == komissiozas[j].cikkszam && i != j)
                {
                    tobbszorSzereploIndexek.Add(i);
                    //meg kell nézni hogy a lista tartalmazza e a j indexet, ha k >= mint a lista akkor nincs benne tehát bele kell tenni
                    int k = 0;
                    while (tobbszorSzereploIndexek.Count > k && tobbszorSzereploIndexek[j] == tobbszorSzereploIndexek[k])
                    { k++; }
                    if (k >= tobbszorSzereploIndexek.Count)
                    {
                       tobbszorSzereploIndexek.Add(j);
                    }
                    j++;
                }
                if (tobbszorSzereploIndexek.Count > 0)
                {
                    int l = 0;
                    int m = 1;
                    int lDarabszam = int.Parse(komissiozas[tobbszorSzereploIndexek[l]].darabszam);
                    int mDarabszam = int.Parse(komissiozas[tobbszorSzereploIndexek[m]].darabszam);
                    string ujDarabszam = lDarabszam + mDarabszam + "";

                    //Megnézi hogy melyik indexen kell módosítani a darabszámot
                    int n = 0;
                    while (!(komissiozas[tobbszorSzereploIndexek[l]].cikkszam == ellenorzottKomissiozas[n].cikkszam))
                    {
                        n++;
                    }
                    int index = n;
                    ellenorzottKomissiozas[index].SetDarabszam(ujDarabszam);
                }
                else
                {
                    ellenorzottKomissiozas.Add(new Komissiozas()
                    {
                        vevo = komissiozas[i].vevo,
                        cikkszam = komissiozas[i].cikkszam,
                        darabszam = komissiozas[i].darabszam
                    });
                }
                i++;
            }
            if (komissiozas.Count < 2)
            {
                ellenorzottKomissiozas.AddRange(komissiozas);
            }
            szallitoLevel.AddRange(ellenorzottKomissiozas);
        }

        internal static List<Komissiozas> GetSzallitoLevel() {  return szallitoLevel; }

        static List<FIFO> fifo = new List<FIFO>();

        private static void FIFO_Ellenorzes(List<Komissiozas> ellenorzottKomissiozas)
        {
            //a feladata hogy összekapcsolja a lokációt egy dátummal ha esetleg több dátum is van az áttárolások miatt akkor adjon hozzá egy új FIFO t 
            //a cikkszám azonos a lokáció legyen ugyan az mint az előző viszont a darabszámot szedje szét a betárolási darab szerint
            
            int hossz = ellenorzottKomissiozas.Count;
            int i = 0;
            while (i < hossz)
            {
                //ha megvan minden lokáció, dátum és darabszám akkor jöjjön a következő cikkszám
                List<string> lokacio = Adatbazis.Kereses(TablaNevek.raktar, OszlopNevek.LokacioID, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam}");
                int a = 0;
                while (lokacio.Count > a)
                {
                    string betarInfo = Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.Komment, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam} AND " +
                        $"{OszlopNevek.LokacioID}={lokacio[a]} AND {OszlopNevek.Komment} NOT LIKE 'K%'");
                    
                    int lokacioDarabszam = int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={lokacio[a]}"));
                    int betaroltDarabszam;

                    if (betarInfo == AnyagmozgasKommentek.Betárolás.ToString() )
                    {
                        betaroltDarabszam = int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.Darabszam, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam}" +
                            $" AND {OszlopNevek.LokacioID}={lokacio[a]} AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Betárolás}'"));
                        if (betaroltDarabszam >= lokacioDarabszam)
                        {
                            string betarolasDatum = Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.Datum, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam}" +
                            $" AND {OszlopNevek.LokacioID}={lokacio[a]} AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Betárolás}'");

                            fifo.Add(new FIFO(betarolasDatum, ellenorzottKomissiozas[i].cikkszam, lokacio[a], lokacioDarabszam + ""));
                        }
                        else
                        {
                            betarInfo = "Áttárolás Ide";
                        }
                    }
                    if (betarInfo ==  AnyagmozgasKommentek.Áttárolás_Ide.ToString() || betarInfo == AnyagmozgasKommentek.Áttárolás_Innen.ToString())
                        // ha áttárolás ide akkor meg kéne nézni hogy van e valami a lokáción, (Ide lokáció)
                        //ha van akkor meg kell nézni hogy az áttárolt darabszám kissebb vagy egyenlő e mint a tényleges darabszám
                        //ha igen akkor a "Betárolás szerint járjunk el" csak a lokáció az (Ide lokáció) lesz
                        //ha nem akkor meg kell nézni hogy az áttárolt darabszám és a bevételezés egyenlő e az (Ide lokáció) darabszámával

                        // ha ide tároltuk meg kéne nézni hogy honnan tároltuk ide (honnan lokáció)
                        // ha a (honnan lokációnak) van betárolása ezzel az anyaggal akkor azt használjuk, azt vegyük fel EZ JÖN
                        // ha nincs betárolása a (honnan lokációnak) akkor meg kell nézni hogy volt e még áttárolva és ott volt e betárolás és így tovább és így tovább
                    {
                        List<string> attarolasInnenLokaciok = Adatbazis.Kereses(TablaNevek.anyagmozgas, OszlopNevek.LokacioID, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam} " +
                        $"AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Áttárolás_Innen}'");
                        List<string> attarolasIdeLokaciok = Adatbazis.Kereses(TablaNevek.anyagmozgas, OszlopNevek.LokacioID, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam} " +
                        $"AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Áttárolás_Ide}'");

                        string betarDatum = Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.Datum, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam} AND" +
                            $" {OszlopNevek.LokacioID}={lokacio[a]} AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Betárolás}'");
                        List<string> kozosLokaciok = new List<string>();
                        kozosLokaciok.AddRange(lokacio);
                        kozosLokaciok.AddRange(attarolasInnenLokaciok);
                        if (betarDatum == "")
                        {
                            int d = 0;
                            while (betarDatum == "" && kozosLokaciok.Count > d)
                            {
                                betarDatum = Adatbazis.EgyAdatLekerese(TablaNevek.anyagmozgas, OszlopNevek.Datum, $"{OszlopNevek.CikkID}={ellenorzottKomissiozas[i].cikkszam} AND" +
                                    $" {OszlopNevek.LokacioID}={kozosLokaciok[d]} AND {OszlopNevek.Komment}='{AnyagmozgasKommentek.Betárolás}'");
                                d++;
                            }
                        }
                        fifo.Add(new FIFO(betarDatum, ellenorzottKomissiozas[i].cikkszam, lokacio[a], lokacioDarabszam + ""));
                    }
                    a++;
                }
                i++;
            }
        }

        static List<FIFO> kiszedes = new List<FIFO>();
        static List<string> darabszamHiba = new List<string>();

        internal static void SetSzallitoLevel() { szallitoLevel.Clear(); }

        internal static bool AutomataKomissio(List<Komissiozas> komissiozas)
        {
            ListaEllenorzes(komissiozas);
            FIFO_Ellenorzes(ellenorzottKomissiozas);
            bool vanAnnyiDarab = false;
            int i = 0;
            string datum = DateTime.Now.ToString();
            while (ellenorzottKomissiozas.Count > i)
            {
                //kiválogatás tételével egy listába teszem az egyforma cikkszámok indexeit hogy késöbb lehessen használni a darabszámoknál
                int j = 0;
                List<int> egyezoCikkszam = new List<int>();
                while (fifo.Count > j)
                {
                    if (ellenorzottKomissiozas[i].cikkszam == fifo[j].cikkszam)
                    {
                        egyezoCikkszam.Add(j);
                    }
                    j++;
                }
                int lokacioDarabszam = 0;
                int l = 0;
                int kertDarabszam = int.Parse(ellenorzottKomissiozas[i].darabszam);
                int fifoDarabszam = int.Parse(fifo[egyezoCikkszam[l]].darabszam);
                while (kertDarabszam != lokacioDarabszam && egyezoCikkszam.Count > l)
                {
                    if ((lokacioDarabszam + fifoDarabszam) > kertDarabszam)
                    {
                        int darab = kertDarabszam - lokacioDarabszam;
                        lokacioDarabszam += darab;
                        kiszedes.Add(new FIFO(datum, fifo[egyezoCikkszam[l]].cikkszam, fifo[egyezoCikkszam[l]].lokacio, darab + ""));
                    }
                    else
                    {
                        lokacioDarabszam += int.Parse(fifo[egyezoCikkszam[l]].darabszam);
                        kiszedes.Add(new FIFO(datum, fifo[egyezoCikkszam[l]].cikkszam, fifo[egyezoCikkszam[l]].lokacio, fifo[egyezoCikkszam[l]].darabszam));
                    }
                    l++;
                }
                if (lokacioDarabszam == kertDarabszam)
                {
                    vanAnnyiDarab = true;
                }
                else
                {
                    darabszamHiba.Add(ellenorzottKomissiozas[i].cikkszam);
                }
                i++;
            }
            ellenorzottKomissiozas.Clear();
            fifo.Clear();
            return vanAnnyiDarab;
        }
        internal static List<string> DarabszamHiba() { return darabszamHiba; }

        internal static List<FIFO> GetKiszedes() { return kiszedes; }

        internal static void SetKiszedes() { kiszedes.Clear(); }
    }
}
