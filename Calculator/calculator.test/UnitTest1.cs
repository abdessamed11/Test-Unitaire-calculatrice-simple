using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculator.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingAdd()
        {
            Calculators operation = new Calculators();
           double resultat = operation.Addition(50, 5);
            Assert.AreEqual(resultat, 55);
        }

        [TestMethod]
        public void TestingSubstract()
        {
         
            Calculators operation = new Calculators();
            double resultat = operation.Soustraction(34, 3);
           Assert.AreEqual(resultat, 31);
        }

        [TestMethod]
        public void TestingDivide()
        {

            Calculators operation = new Calculators();
            double resultat = operation.Division(10, 2);
           Assert.AreEqual(resultat, 5);
        }


        [TestMethod]
        public void TestingMultiply()
        {

            Calculators operation = new Calculators();
            double resultat = operation.Multiplication(7, 100);
            Assert.AreEqual(resultat, 700);
        }
    }
}
