namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquationSolver quadraticEquationSolver = new QuadraticEquationSolver(3, 4, 2);

            double x1 = quadraticEquationSolver.X1;
        }
    }
}