
namespace Szakdolgozat
{
    public class FIFO
    {
        public string datum { get; set; }
        public string cikkszam { get; set; }
        public string lokacio { get; set; }
        public string darabszam { get; set; }

        public FIFO(string datum, string cikkszam, string lokacio, string darabszam)
        {
            this.datum = datum;
            this.cikkszam = cikkszam;
            this.lokacio = lokacio;
            this.darabszam = darabszam;

        }
    }
}
