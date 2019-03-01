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
    }
}
