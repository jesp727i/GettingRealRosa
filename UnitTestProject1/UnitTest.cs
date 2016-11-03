using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingRealRosa
{
    [TestClass]
    public class Opretgarn
    {

        Garn garn = new Garn();
        
        [TestMethod]
        public void OpretGarnNavn()
        {
            
            garn.Name = "Alpaka";
            string result = garn.Name;
            Assert.AreEqual("Alpaka", result);
        }
        [TestMethod]
        public void OpretGarnFarve()
        {
            garn.Farve = "Rød";
            string result = garn.Farve;
            Assert.AreEqual("Rød", result);
        }
        [TestMethod]
        public void OpretGarnType()
        {
            garn.Type = "Alpaka";
            string result = garn.Type;
            Assert.AreEqual("Alpaka", result);
        }
        [TestMethod]
        public void OpretGarnMaengde()
        {
            garn.Amount = 1;
            int result = garn.Amount;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void OpretGarnPris()
        {
            garn.Price = 192.10f;
            float result = garn.Price;
            Assert.AreEqual(192.10f, result);
        }
        [TestMethod]
        public void laegTilMaengde()
        {
            garn.Amount = 1;
            garn.AddAmount(9);
            int result = garn.Amount;
            Assert.AreEqual(10,result);
        }
        [TestMethod]
        public void TraekFraMaengde()
        {
            garn.Amount = 10;
            garn.SubAmount(9);
            int result = garn.Amount;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void EAndreNavnPaaGarn()
        {

            garn.ChangeName("Alpakke");
            Assert.AreEqual("Alpakke", garn.Name);
        }

        [TestMethod]
        public void a()
        {
            Assert.AreEqual(1,1);
        }

    }
}
