using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.dal.Tests
{
    [TestClass()]
    public class AccessTests
    {
        private static readonly Access access = Access.GetInstance();

        [TestMethod()]
        public void ParutionDansAbonnementTest()
        {
            DateTime dateCommande = new DateTime(2025, 03, 05);
            DateTime dateParution = new DateTime(2025, 03, 06);
            DateTime dateFinAbonnement = new DateTime(2025, 03, 07);

            bool expected = true;
            bool actual = access.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);

            Assert.AreEqual(expected, actual);
        }
    }
}