using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_01_Oraimunka_teszteles_jaratkezelo
{
    class Jaratkezelo
    {
        class Jarat
        {
            public string Jaratszam { get; set; }
            public string HonnanRepter { get; set; }
            public string HovaRepter { get; set; }
            public DateTime Indulas { get; set; }
            public int Keses { get; set; }

            public Jarat(string jaratszam, string honnanRepter, string hovaRepter, DateTime indulas)
            {
                this.Jaratszam = jaratszam;
                this.HonnanRepter = honnanRepter;
                this.HovaRepter = hovaRepter;
                this.Indulas = indulas;
                this.Keses = 0;
            }
        }
        List<Jarat> Jaratok_lista = new List<Jarat>();
        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            var jarat = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
            for (int i = 0; i < Jaratok_lista.Count; i++)
            {
                if (Jaratok_lista[i].Jaratszam.Equals(jaratSzam))
                {
                    throw new ArgumentException("A járatszám ugyanaz!");
                }
            }
            Jaratok_lista.Add(jarat);
        }
        public void Keses(string jaratSzam, int keses)
        {

        }
        public DateTime MikorIndul(string jaratSzam)
        {
            return new DateTime();
        }
        public List<string> JaratokRepuloterrol(string repter)
        {
            return null;
        }
    }
}