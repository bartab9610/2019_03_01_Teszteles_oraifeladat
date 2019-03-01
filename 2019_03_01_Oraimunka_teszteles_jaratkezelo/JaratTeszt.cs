using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_03_01_Oraimunka_teszteles_jaratkezelo
{
    [TestFixture]
    class JaratTeszt
    {
        Jaratkezelo Jarat;
        [SetUp]
        public void SetUp()
        {
            Jarat = new Jaratkezelo();
        }
        [Test]
        public void Jarat_ugyanaz()
        {
            Jarat.UjJarat("Debreczeni Laci", "suli", "kocsma", DateTime.Now);
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.UjJarat("Debreczeni Laci", "suli", "kocsma", DateTime.Now);
            });
        }
        [Test]
        public void Jarat_ures_jarat_Jarat_repter() // Hibás járatszám vagy hibás reptér
        {
            Jarat.UjJarat("Debreczeni Laci", "suli", "kocsma", DateTime.Now);
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.UjJarat("", "suli", "kocsma", DateTime.Now);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.UjJarat("Debreczeni Laci", "", "kocsma", DateTime.Now);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.UjJarat("Debreczeni Laci", "suli", "", DateTime.Now);
            });
        }
        [Test]
        public void Jarat_keses_0()
        {
            Jarat.UjJarat("00112233", "valami", "valami2",DateTime.Now);
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.Keses("00112233", 0);
            });
        }
        [Test]
        public void Jarat_minusz_keses()
        {
            Jarat.UjJarat("00112233", "valami", "valami2", DateTime.Now);
            Assert.Throws<NegativKesesException>(() =>
            {
                Jarat.Keses("00112233", -5);
            });
        }
        [Test]
        public void Jarat_nem_letezik()
        {
            Jarat.UjJarat("1122", "valami", "valami2", DateTime.Now);
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.Keses("5", 10);
            });
        }
        [Test]
        public void Jarat_indulas_jo_parameter()
        {
            DateTime now = DateTime.Now;
            Jarat.UjJarat("Jó paraméter", "valami", "valami2", now);
            Assert.AreEqual(now,Jarat.MikorIndul("Jó paraméter"));
        }
        [Test]
        public void Jarat_indulas_rossz_parameter()
        {
            Jarat.UjJarat("Rossz paraméter", "valami", "valami2", DateTime.Now);
            Assert.Throws<ArgumentException>(() =>
            {
                Jarat.MikorIndul("");
            });
        }
    }
}