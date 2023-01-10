using QuadraticEquation;

namespace TestProject
{
    [TestClass]
    public class TestingComplexNumber
    {
        [TestMethod]
        public void TestToString()
        {
            // Assign
            ComplexNumber complex = new ComplexNumber(4, 5);
            ComplexNumber complex1 = new ComplexNumber(0, 5);
            ComplexNumber complex2 = new ComplexNumber(4, 0);
            ComplexNumber complex3 = new ComplexNumber(0, 0);

            // Act
            string s = complex.ToString();
            string sa = complex1.ToString();
            string sb = complex2.ToString();
            string s0 = complex3.ToString();

            // Assert
            Assert.AreEqual("4 + i5", s);
            Assert.AreEqual("i5", sa);
            Assert.AreEqual("4", sb);
            Assert.AreEqual("0", s0);
        }

        [TestMethod]
        public void TestPlusOp()
        {
            // Assign
            ComplexNumber complex = new ComplexNumber(4, 5);
            ComplexNumber complex1 = new ComplexNumber(10, 15);

            // Act
            ComplexNumber sum = complex + complex1;

            // Assert
            Assert.IsTrue(sum.A == 14 && sum.B == 20);
        }
    }
}