using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RömischeZahlen.Tests
{
    [TestClass]
    public class DezimalzahlenWandlerTests
    {
        DezimalzahlenWandler sut;

        [TestInitialize]
        public void Init()
        {
            sut = new DezimalzahlenWandler();
        }

        [TestMethod]
        public void Wenn_XIV_gegeben_ergebnis_ist_10_1_5()
        {
            var erg = sut.RömischeZahlInDezimal("XIV");
            CollectionAssert.AreEqual(new int[] { 10, 1, 5 }, erg.ToArray());
        }

        [TestMethod]
        public void Wenn_10_1_5_gegeben_ergebnis_5_minus1_10()
        {
            var erg = sut.ZahlenWertBestimmen(new int[] { 10, 1, 5 });
            //Assert.AreEqual(0, erg.Count());
            CollectionAssert.AreEqual(new int[] { 5, -1, 10 }, erg.ToArray());
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
