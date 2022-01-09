using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;


namespace Szakdolgozat
{
    public enum TablaNevek
    {
        anyagmozgas, cikkek, felhasznalo, raktar, vallalat
    }
    public enum OszlopNevek
    {
        AnyagmozgasID, Datum, SzallitoSzam, CikkID, Darabszam, LokacioID, FelhasznaloID, Komment,
        VallalatCikk, VallalatMegjegyzes, VallalatID,
        FelhasznaloNev, Jelszo, Nev, Beosztas,
        VallalatNev, VallalatCim, VallalatEmail, VallalatTelefon
    }
    public enum AnyagmozgasKommentek
    {
        Betárolás, Áttárolás_Innen, Áttárolás_Ide, Kiszállítás
    }

    class Adatbazis
    {

        internal static string kapcsolatAllapot;
        private static string adatbazisEleres = "datasource=127.0.0.1;port=3306;username=root;password=;database=szakdolgozat;SslMode=none";
        //A Mysql.Data 8.0.26.0 -ás verziója miatt szükség van az "SslMode=none" parancsra!
        private static readonly MySqlConnection kapcsolodas = new MySqlConnection(adatbazisEleres);


        public Adatbazis() 
        {

            MySqlConnection kapcsolodas = new MySqlConnection(adatbazisEleres);

            try
            {
                kapcsolodas.Open();
                kapcsolatAllapot = "Kapcsolódott!";
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        //Ezzel a metódussal EGY adatokat lehet lekérni, meg kell adni az aktuális táblát és a tábla sorát egy listát ad vissza
        internal static List<string> Lekerdezes(TablaNevek tabla, OszlopNevek oszlop)
        {
            List<string> lekerdezes = new List<string>();
            try
            {
                kapcsolodas.Open();
                MySqlCommand abParancs = new MySqlCommand($"SELECT {oszlop} FROM {tabla};", kapcsolodas);
                MySqlDataReader olvaso = abParancs.ExecuteReader();
                
                kapcsolatAllapot = "Kapcsolódott!";

                while (olvaso.Read())
                {
                    string lekertAdat = olvaso.GetString(oszlop.ToString());
                    lekerdezes.Add(lekertAdat);
                }
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
            return lekerdezes;
        }

        internal static List<string> Lekerdezes(TablaNevek tabla, OszlopNevek oszlop1, OszlopNevek oszlop2)
        {
            List<string> lekerdezes = new List<string>();
            try
            {
                kapcsolodas.Open();
                MySqlCommand abParancs = new MySqlCommand($"SELECT {oszlop1},{oszlop2} FROM {tabla};", kapcsolodas);
                MySqlDataReader olvaso = abParancs.ExecuteReader();

                kapcsolatAllapot = "Kapcsolódott!";

                while (olvaso.Read())
                {
                    string lekertAdat = olvaso.GetString(oszlop1.ToString());
                    lekertAdat += " " + olvaso.GetString(oszlop2.ToString());
                    lekerdezes.Add(lekertAdat);
                }
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
            return lekerdezes;
        }

        internal static string EgyAdatLekerese(TablaNevek tabla, OszlopNevek column, string where)
        {
            string lekerdezettAdat = "";
            try
            {
                kapcsolodas.Open();
                MySqlCommand abParancs = new MySqlCommand($"SELECT {column} FROM {tabla} WHERE {where};", kapcsolodas);
                MySqlDataReader olvaso = abParancs.ExecuteReader();

                kapcsolatAllapot = "Kapcsolódott!";

                while (olvaso.Read())
                {
                    lekerdezettAdat = olvaso.GetString(0);

                }
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
                if (e.InnerException == null)
                {
                    lekerdezettAdat = null;
                    kapcsolodas.Close();
                } 
            }
            return lekerdezettAdat;
        }

        internal static List<string> Kereses(TablaNevek table, OszlopNevek column, string where)
        {
            List<string> lekerdezes = new List<string>();
            try
            {
                kapcsolodas.Open();
                MySqlCommand abParancs = new MySqlCommand($"SELECT {column} FROM {table} WHERE {where};", kapcsolodas);
                MySqlDataReader olvaso = abParancs.ExecuteReader();

                kapcsolatAllapot = "Kapcsolódott!";

                while (olvaso.Read())
                {
                    string lekertAdat = olvaso.GetString(column.ToString());
                    lekerdezes.Add(lekertAdat);

                }
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
            return lekerdezes;
        }
        

        internal static void BevetelezesLokaciora(int szamlalo)
        {
            try
            {
                Bevetelezes bevetelezes = new Bevetelezes();
                string utasitas = "";
                string where = $"{OszlopNevek.LokacioID}='{Bevetelezes.betarolas[szamlalo].GetLokacioID()}'";
                string darabszam = EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, where);
                if (darabszam == null)
                {
                    utasitas = $"UPDATE {TablaNevek.raktar} SET {OszlopNevek.CikkID}='{Bevetelezes.betarolas[szamlalo].GetCikkID()}', {OszlopNevek.Darabszam}='{Bevetelezes.betarolas[szamlalo].GetDarabszam()}'" +
                    $"WHERE {OszlopNevek.LokacioID}='{Bevetelezes.betarolas[szamlalo].GetLokacioID()}'";
                }
                if(darabszam != null && int.Parse(EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.CikkID, where)) == Bevetelezes.betarolas[szamlalo].GetCikkID())
                {
                    int db = int.Parse(darabszam);
                    db += Bevetelezes.betarolas[szamlalo].GetDarabszam();
                    utasitas = $"UPDATE {TablaNevek.raktar} SET {OszlopNevek.CikkID}='{Bevetelezes.betarolas[szamlalo].GetCikkID()}', {OszlopNevek.Darabszam}='{db}'" +
                    $"WHERE {OszlopNevek.LokacioID}='{Bevetelezes.betarolas[szamlalo].GetLokacioID()}'";
                }
                
                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();
                kapcsolatAllapot = "Kapcsolódott!";
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void Betarolas(int szamlalo)
        {
            if (Bevetelezes.betarolas.Any())
            {
                try
                {
                    int felhasznaloID = Bejelentkezes.GetFelhasznaloID();
                    string utasitas;
                    if (Bevetelezes.betarolas[szamlalo].GetSzallitoSzam() > 0)
                    {
                        utasitas = $"INSERT INTO {TablaNevek.anyagmozgas}({OszlopNevek.Datum}, {OszlopNevek.SzallitoSzam}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, {OszlopNevek.LokacioID}, " +
                                $"{OszlopNevek.FelhasznaloID}, {OszlopNevek.Komment}) VALUES ('{Bevetelezes.betarolas[szamlalo].GetDatum()}', '{Bevetelezes.betarolas[szamlalo].GetSzallitoSzam()}', " +
                                $"'{Bevetelezes.betarolas[szamlalo].GetCikkID()}', '{Bevetelezes.betarolas[szamlalo].GetDarabszam()}', " +
                                $"'{Bevetelezes.betarolas[szamlalo].GetLokacioID()}', '{felhasznaloID}', '{AnyagmozgasKommentek.Betárolás}')";
                        
                    }
                    else
                    {
                        utasitas = $"INSERT INTO {TablaNevek.anyagmozgas} ({OszlopNevek.Datum}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, {OszlopNevek.LokacioID}, " +
                            $"{OszlopNevek.FelhasznaloID}, {OszlopNevek.Komment}) VALUES ('{Bevetelezes.betarolas[szamlalo].GetDatum()}', " +
                            $"'{Bevetelezes.betarolas[szamlalo].GetCikkID()}', '{Bevetelezes.betarolas[szamlalo].GetDarabszam()}', " +
                            $"'{Bevetelezes.betarolas[szamlalo].GetLokacioID()}', '{felhasznaloID}', '{AnyagmozgasKommentek.Betárolás}')";
                    }

                    MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                    MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                    MySqlDataReader olvaso;
                    ujKapcsolat.Open();
                    olvaso = abParancs.ExecuteReader();
                    while (olvaso.Read()) { }
                    ujKapcsolat.Close();

                    kapcsolatAllapot = "Kapcsolódott!";
                }
                catch (Exception e)
                {
                    kapcsolatAllapot = "HIBA " + e.Message;
                }
            }
        }

        internal static void AttarolasIde(string cikkszam, string darabszam, string ujLokacio)
        {
            int felhasznaloID = Bejelentkezes.GetFelhasznaloID();
            string datum = DateTime.Today.ToString("yyyy-MM-dd");
            try
            {
                string utasitas = $"INSERT INTO {TablaNevek.anyagmozgas} ({OszlopNevek.Datum}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, {OszlopNevek.LokacioID}, " +
                            $"{OszlopNevek.FelhasznaloID}, {OszlopNevek.Komment}) VALUES ('{datum}','{cikkszam}','{darabszam}'," +
                            $" '{ujLokacio}','{felhasznaloID}','{AnyagmozgasKommentek.Áttárolás_Ide}')";

                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();

                kapcsolatAllapot = "Kapcsolódott!";

            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void AttarolasInnen(string cikkszam, string darabszam, string regiLokacio)
        {
            int felhasznaloID = Bejelentkezes.GetFelhasznaloID();
            string datum = DateTime.Today.ToString("yyyy-MM-dd");
            try
            {
                string utasitas = $"INSERT INTO {TablaNevek.anyagmozgas} ({OszlopNevek.Datum}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, {OszlopNevek.LokacioID}, " +
                            $"{OszlopNevek.FelhasznaloID}, {OszlopNevek.Komment}) VALUES ('{datum}','{cikkszam}','{darabszam}'," +
                            $" '{regiLokacio}','{felhasznaloID}','{AnyagmozgasKommentek.Áttárolás_Innen}')";

                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();

                kapcsolatAllapot = "Kapcsolódott!";

            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void AttarolasLokaciora(int lokacio, string cikkszam, int darabszam)
        {
            string utasitas = $"UPDATE {TablaNevek.raktar} SET {OszlopNevek.CikkID}='{cikkszam}', {OszlopNevek.Darabszam}='{darabszam}'" +
                    $"WHERE {OszlopNevek.LokacioID}='{lokacio}'";
            try
            {
                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();

                kapcsolatAllapot = "Kapcsolódott!";
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void SetLokacioNull(Nullable<int> legyenNull, string lokacio)
        {
            string utasitas = $"UPDATE {TablaNevek.raktar} SET {OszlopNevek.CikkID} = NULL, {OszlopNevek.Darabszam} = NULL WHERE {OszlopNevek.LokacioID}='{lokacio}'"; 
            try
            {
                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();

                kapcsolatAllapot = "Kapcsolódott!";
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void Kiszallitas(List<FIFO> kiszedes, string szallitoLevelSzam)
        {
            try
            {
                int felhasznaloID = Bejelentkezes.GetFelhasznaloID();
                string datum = DateTime.Today.ToString("yyyy-MM-dd");
                string utasitas;
                int i = 0;
                while (kiszedes.Count > i)
                {
                    utasitas = $"INSERT INTO {TablaNevek.anyagmozgas}({OszlopNevek.Datum}, {OszlopNevek.SzallitoSzam}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, " +
                    $"{OszlopNevek.LokacioID}, {OszlopNevek.FelhasznaloID}, {OszlopNevek.Komment}) VALUES ('{datum}', '{szallitoLevelSzam}', '{kiszedes[i].cikkszam}', " +
                    $"'{kiszedes[i].darabszam}', '{kiszedes[i].lokacio}', '{felhasznaloID}', '{AnyagmozgasKommentek.Kiszállítás}')";
                    MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                    MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                    MySqlDataReader olvaso;
                    ujKapcsolat.Open();
                    olvaso = abParancs.ExecuteReader();
                    while (olvaso.Read()) { }
                    ujKapcsolat.Close();

                    kapcsolatAllapot = "Kapcsolódott!";
                    i++;
                }
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void UpdateDarabszam(string lokacio, string darabszam)
        {
            string utasitas = $"UPDATE {TablaNevek.raktar} SET {OszlopNevek.Darabszam}='{darabszam}'" +
                    $"WHERE {OszlopNevek.LokacioID}='{lokacio}'";
            try
            {
                MySqlConnection ujKapcsolat = new MySqlConnection(adatbazisEleres);
                MySqlCommand abParancs = new MySqlCommand(utasitas, ujKapcsolat);
                MySqlDataReader olvaso;
                ujKapcsolat.Open();
                olvaso = abParancs.ExecuteReader();
                while (olvaso.Read()) { }
                ujKapcsolat.Close();

                kapcsolatAllapot = "Kapcsolódott!";
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
        }

        internal static void KiszallitasRaktar(List<FIFO> kiszedes)
        {
            int i = 0;
            while (kiszedes.Count > i)
            {
                int lokacioDarab = int.Parse(Adatbazis.EgyAdatLekerese(TablaNevek.raktar, OszlopNevek.Darabszam, $"{OszlopNevek.LokacioID}={kiszedes[i].lokacio}"));
                if (int.Parse(kiszedes[i].darabszam) == lokacioDarab)
                {
                    //ha egyezik a raktári és a lista béli darabszám akkor a raktári cikkszám és darabszám is legyen NULL
                    Adatbazis.SetLokacioNull(null,kiszedes[i].lokacio);
                }
                else//ki kell vonni a raktárban lévő darabszámokból a listában lévő darabszámokat
                {
                    int maradek = lokacioDarab - int.Parse(kiszedes[i].darabszam);
                    Adatbazis.UpdateDarabszam(kiszedes[i].lokacio,maradek + "");
                }
                i++;
            }
        }

        internal static List<Lekerdezes> Info(string where)
        {
            List<Lekerdezes> lekerdezes = new List<Lekerdezes>();
            try
            {
                kapcsolodas.Open();
                MySqlCommand abParancs = new MySqlCommand($"SELECT {OszlopNevek.Datum}, {OszlopNevek.CikkID}, {OszlopNevek.Darabszam}, " +
                    $"{OszlopNevek.LokacioID}, {OszlopNevek.Komment} FROM {TablaNevek.anyagmozgas} WHERE {where}", kapcsolodas);
                MySqlDataReader olvaso = abParancs.ExecuteReader();

                kapcsolatAllapot = "Kapcsolódott!";
                
                while (olvaso.Read())
                {
                        lekerdezes.Add(new Lekerdezes() { datum = olvaso.GetString(OszlopNevek.Datum.ToString()), 
                            cikkszam = olvaso.GetString(OszlopNevek.CikkID.ToString()), darabszam = olvaso.GetString(OszlopNevek.Darabszam.ToString()), 
                            lokacio = olvaso.GetString(OszlopNevek.LokacioID.ToString()), konyvelesFajta = olvaso.GetString(OszlopNevek.Komment.ToString())});
                  
                }
                kapcsolodas.Close();
            }
            catch (Exception e)
            {
                kapcsolatAllapot = "HIBA " + e.Message;
            }
            return lekerdezes;
        }
    }
}
