using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Repository.Database;
using Repository.Logic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestBerekenCoalitie()
        {
            Verkiezing verkiezing = new Verkiezing("Tweede kamer verkiezing", 150, 76);
            Formatie formatie = new Formatie(new VerkiezingLocalContext(), verkiezing);
            List<Partij> minderheid = new List<Partij>() { new Partij("vvd", "vvd nogiets", "Piet", 500, 34, 50), new Partij("vvd", "vvd nogiets", "Piet", 500, 34, 20) };
            List<Partij> meerderheid = new List<Partij>() { new Partij("vvd", "vvd nogiets", "Piet", 500, 34, 50), new Partij("vvd", "vvd nogiets", "Piet", 500, 34, 50) };

            formatie.BerekenCoalitie(minderheid);
            Assert.AreEqual(false, formatie.KamerMeerderheid);

            formatie.BerekenCoalitie(meerderheid);
            Assert.AreEqual(true, formatie.KamerMeerderheid);
        }

        [TestMethod]
        public void TestBerekenUitslag()
        {
            Verkiezing verkiezing = new Verkiezing("Tweede kamer verkiezing", 150, 76);
            Formatie formatie = new Formatie(new VerkiezingLocalContext(), verkiezing);
            List<Partij> partijen = new List<Partij>() { new Partij("vvd", "vvd nogiets", "Piet"), new Partij("vvd", "vvd nogiets", "Piet"), new Partij("vvd", "vvd nogiets", "Piet"), new Partij("vvd", "vvd nogiets", "Piet") };
            partijen[0].SetStemmen(50);
            partijen[1].SetStemmen(150);
            partijen[1].SetStemmen(35);
            partijen[1].SetStemmen(86);

            formatie.BerekenUitslag(partijen);

            Assert.AreEqual(150, partijen.Sum(p => p.Zetels));
        }
    }
}