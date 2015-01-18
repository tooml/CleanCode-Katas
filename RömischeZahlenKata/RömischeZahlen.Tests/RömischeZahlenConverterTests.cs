using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RömischeZahlen.Tests
{
    [TestClass]
    public class RömischeZahlenConverterTests
    {
        RömischeZahlenConverter sut;

        [TestInitialize]
        public void Init()
        {
            sut = new RömischeZahlenConverter();
        }

        [TestMethod]
        public void Wenn_XIV_gegeben_ergebnis_ist_10_1_5()
        {
            var erg = sut.RömischeZahlenInDezimal("XIV");
            CollectionAssert.AreEqual(new int[] { 10, 1, 5 }, erg.ToArray());
        }

        [TestMethod]
        public void Wenn_10_1_5_gegeben_ergebnis_10_minus1_5()
        {
            var erg = sut.ZahlenWertBestimmen(new int[] { 10, 1, 5 });
            CollectionAssert.AreEqual(new int[] { 10, -1, 5 }, erg.ToArray());
        }

        [TestMethod]
        public void Wenn_5_minus1_10_gegeben_ergebnis_14()
        {
            var erg = sut.ZahlenSummieren(new int[] { 5, -1, 10 });
            Assert.AreEqual(14, erg);
        }

        [TestMethod]
        public void IntegrationTest_Wenn_CDLVIII_gegeben_ergebnis_458()
        {
            var erg = sut.ParseRömischeZahlInDezimal("CDLVIII");
            Assert.AreEqual(458, erg);
        }

        [TestMethod]
        public void IntegrationTest_Wenn_MDCLXXIX_gegeben_ergebnis_1679()
        {
            var erg = sut.ParseRömischeZahlInDezimal("MDCLXXIX");
            Assert.AreEqual(1679, erg);
        }
   
        [TestCleanup]
        public void Cleanup()
        {
            sut = null;
        }
    }
}
