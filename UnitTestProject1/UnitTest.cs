using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryRosa;
using System.Collections.Generic;

namespace GettingRealRosa
{
    [TestClass]
    public class Opretgarn
    {

        Garn garn;
        ProductReposetory productList;

        [TestInitialize]
        public void TestSetup()
        {
            productList = new ProductReposetory();
            garn = new Garn(); 
            Garn garn1 = new Garn();
            Garn garn2 = new Garn();
            productList.ProductList.Add(garn1);
            productList.ProductList.Add(garn2);


        }

        [TestMethod]
        public void OpretGarnNavn()
        {
            garn.Name = "Alpaka";
            Assert.AreEqual("Alpaka", garn.Name);
        }

        [TestMethod]
        public void OpretGarnFarve()
        {
            garn.Color = "Rød";
            Assert.AreEqual("Rød", garn.Color);
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
            garn.Price = 192.10;
            Assert.AreEqual(192.10, garn.Price);
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
        public void CanSaveGarnToList()
        {
            Garn garn = new Garn(3, "Alpaka", "himmelgarn", 5, 10.50, "Blue");
            productList.ProductList.Add(garn);
            Assert.AreEqual(garn, productList.ProductList[2]);
        }

        [TestMethod]
        public void CanDeleteFromList()
        {
            Garn garn = new Garn(3, "Alpaka", "himmelgarn", 5, 10.50, "Blue");
            productList.AddProduct(garn);
            Assert.AreEqual(garn, productList.ProductList[2]);
            productList.DeleteProduct(2);
            Assert.AreEqual(false, productList.ProductList.Contains(garn));

        }

        [TestMethod]
        public void a()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
