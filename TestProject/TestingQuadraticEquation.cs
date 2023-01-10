using QuadraticEquation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestingQuadraticEquation
    {
        [TestMethod]
        public void Determinant()
        {
            // Assign
            QuadraticEquationSolver equationSolver = new QuadraticEquationSolver(2, 3, 4);

            // Act
            double d = equationSolver.D;

            // Assert
            Assert.AreEqual(-23, d);
        }
    }
}
