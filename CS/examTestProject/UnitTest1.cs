using NUnit.Framework;
using BID.SWE.EXAM.Impl;
using System.IO;

namespace examTestProject
{
    public class Tests
    {
        // this is a setup method
        [SetUp]
        public void Setup()
        {
        }

        // this is a test method
        [Test]
        public void Exercise1Method1Test1()
        {
            Exercise1 e1 = new Exercise1();
            CellPrinter returnedObject = (CellPrinter)e1.Method1();
            CellPrinter expectedObject = new CellPrinter();
            Assert.AreEqual(returnedObject.GetType(), expectedObject.GetType());
        }

        [Test]
        public void Exercise1Method1Test2()
        {
            Exercise1 e1 = new Exercise1();
            CellPrinter returnedObject = (CellPrinter)e1.Method1();
            Assert.AreEqual(returnedObject.PrintPostion(1,2), "Cell is on Position X:1 Y:2");
        }

        [Test]
        public void Exercise1Method1Test3()
        {
            Exercise1 e1 = new Exercise1();
            CellPrinter returnedObject = (CellPrinter)e1.Method1();
            Assert.AreEqual(returnedObject.PrintState(true, new System.DateTime(2019, 12, 12), "red"), "Cell red born on 12.12.2019 is alive");
        }

        [Test]
        public void Exercise2Method2Test1()
        {
            MySecondCell secondCell = new MySecondCell();
            Assert.AreEqual(secondCell.Grow(), 2);
        }

        [Test]
        public void Exercise2Method3Test1()
        {
            MyThirdCell cellObj = new MyThirdCell();
            Assert.AreEqual(cellObj.IsAlive(2), true);
        }

        [Test]
        public void Exercise2Method3Test2()
        {
            MyThirdCell cellObj = new MyThirdCell();
            Assert.AreEqual(cellObj.IsAlive(), true);
        }

        [Test]
        public void Exercise3Method1Test1()
        {
            Exercise3 e3 = new Exercise3();
            MyMap map = (MyMap)e3.Method1();
            Assert.AreEqual(map.GetMapName(), "BID-Map");
        }

        [Test]
        public void Exercise3Method1Test2()
        {
            Exercise3 e3 = new Exercise3();
            MyMap map = (MyMap)e3.Method1();
            Assert.AreEqual(map.GetMapSize(5), 25);
        }

        [Test]
        public void Exercise3Method1Test3()
        {
            Exercise3 e3 = new Exercise3();
            MyMap map = (MyMap)e3.Method1();
            Assert.AreEqual(map.AddNewCells(2011), 2011);
        }

        [Test]
        public void Exercise3Method2Test1()
        {
            Exercise3 e3 = new Exercise3();
            Bewegung[] bewegungen = (Bewegung[])e3.Method2();
            Laufen laufen = new Laufen();
            Assert.AreEqual(bewegungen[0].GetType(), laufen.GetType());
        }

        [Test]
        public void Exercise4Method1Test1()
        {
            Exercise4 e4 = new Exercise4();
            Stream stream = (Stream)e4.Method1();
            Assert.That(stream, Is.Not.Null);
        }

        [Test]
        public void Exercise4Method2Test1()
        {
            Exercise4 e4 = new Exercise4();
            Stream stream = (Stream)e4.Method1();
            string text = (string)e4.Method2(stream);
            Assert.AreEqual(text, "Frohe Weihnachten");
        }

    }
}