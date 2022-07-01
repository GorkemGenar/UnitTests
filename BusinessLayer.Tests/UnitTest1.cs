using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; } 

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Kullanicilar.xml", 
            "Kullanici",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager = new KullaniciManager();

            var ad = TestContext.DataRow["ad"].ToString();
            var telefon = TestContext.DataRow["telefon"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();

            var sonuc = manager.KullaniciEkle(ad, telefon, mail);

            Assert.IsTrue(sonuc);
        }
    }
}
