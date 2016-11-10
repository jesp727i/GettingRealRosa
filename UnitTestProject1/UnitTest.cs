using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryRosa;

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
            Assert.AreEqual("Alpaka", garn.Name);
        }
        [TestMethod]
        public void OpretGarnFarve()
        {
            garn.Farve = "Rød";
            Assert.AreEqual("Rød", garn.Farve);
        }
        [TestMethod]
        public void OpretGarnType()
        {
            garn.Type = "Alpaka";
            Assert.AreEqual("Alpaka", garn.Type);
        }
        [TestMethod]
        public void OpretGarnMaengde()
        {
            garn.Amount = 1;
            Assert.AreEqual(1, garn.Amount);
        }
        [TestMethod]
        public void OpretGarnPris()
        {
            garn.Price = 192.10f;
            Assert.AreEqual(192.10f, garn.Price);
        }
        /*[TestMethod]
        public void OpretGarnId()
        {
            garn.Id = 1;
            Assert.AreEqual(192.10f, garn.Id);
        }*/

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
