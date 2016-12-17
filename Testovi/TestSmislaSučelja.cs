﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Collections.Generic;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestSmislaSučelja
    {
        static List<Osoba> PopisOsoba()
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", new DateTime(1975, 7, 12), "Split"));
            popisOsoba.Add(new Osoba("Žarko", new DateTime(1965, 12, 4), "Osijek"));
            popisOsoba.Add(new Osoba("Marko", new DateTime(1983, 4, 2), "Sinj"));
            popisOsoba.Add(new Osoba("Tomislav", new DateTime(1971, 11, 5), "Beli Manastir"));

            return popisOsoba;
        }

        [TestMethod]
        public void SmisaoSučelja_SortiranjePoImenu()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            SmisaoSučelja.SortiranoPoImenu(popisOsoba);
            Assert.AreEqual("Ana", popisOsoba[0].Ime);
            Assert.AreEqual("Marko", popisOsoba[1].Ime);
            Assert.AreEqual("Tomislav", popisOsoba[2].Ime);
            Assert.AreEqual("Žarko", popisOsoba[3].Ime);
        }

        [TestMethod]
        public void SmisaoSučelja_SortiranjePoDatumuRođenja()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            SmisaoSučelja.SortiranoPoDatumuRođenja(popisOsoba);
            Assert.AreEqual("Žarko", popisOsoba[0].Ime);
            Assert.AreEqual("Tomislav", popisOsoba[1].Ime);
            Assert.AreEqual("Ana", popisOsoba[2].Ime);
            Assert.AreEqual("Marko", popisOsoba[3].Ime);
        }

        [TestMethod]
        public void SmisaoSučelja_SortiranjePoMjestuRođenja()
        {
            List<Osoba> popisOsoba = PopisOsoba();
            SmisaoSučelja.SortiranoPoMjestuRođenja(popisOsoba);
            Assert.AreEqual("Tomislav", popisOsoba[0].Ime);
            Assert.AreEqual("Žarko", popisOsoba[1].Ime);
            Assert.AreEqual("Marko", popisOsoba[2].Ime);
            Assert.AreEqual("Ana", popisOsoba[3].Ime);
        }
    }
}
