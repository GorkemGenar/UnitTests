using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "    Görkem Akkaya   ";
            var beklenen = "Görkem Akkaya";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }

        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "    Görkem Akkaya     Engin    Demiroğ    Salih      Demiroğ    ";
            var beklenen = "Görkem Akkaya Engin Demiroğ Salih Demiroğ";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
