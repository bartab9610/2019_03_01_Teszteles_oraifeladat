using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_01_Oraimunka_teszteles_jaratkezelo
{
    class Class1
    {
        class Jarat
        {
            public string Jaratszam { get; set; }
            public string HonnanRepter { get; set; }
            public string HovaRepter { get; set; }
            public DateTime Indulas { get; set; }
            public int Keses { get; set; }

            public Jarat(string jaratszam, string honnanRepter, string hovaRepter, DateTime indulas, int keses)
            {
                this.Jaratszam = jaratszam;
                this.HonnanRepter = honnanRepter;
                this.HovaRepter = hovaRepter;
                this.Indulas = indulas;
                this.Keses = 0;
            }
        }
        void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {

        }
        void Keses(string jaratSzam, int keses)
        {

        }
        DateTime MikorIndul(string jaratSzam)
        {
            return new DateTime();
        }
        List<string> JaratokRepuloterrol(string repter)
        {
            return null;
        }
    }
}