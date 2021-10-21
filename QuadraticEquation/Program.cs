using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak2Tests();
            Zadatak3Tests();

        }

        static void Zadatak3Tests()
        {
            var c1 = new Complex(1, 2);
            var c2 = new Complex(3, 4);
            var c6 = new Complex(5, 5);
            var c8 = new Complex(2, 1);

            var c3 = c1 + c2;
            var c3_expected = new Complex(4, 6);
            var success = c3.Equal(c3_expected) ? "Successful" : "Failed";
            Console.WriteLine("Test addition was " + success);

            var c4 = c2 - c8;
            var c4_expected = new Complex(1, 3);

            success = c4.Equal(c4_expected) ? "Successful" : "Failed";
            Console.WriteLine("Test subtraction was " + success);

            var c5 = c1 * c2;
            var c5_expected = new Complex(-5, 10);

            success = c5.Equal(c5_expected) ? "Successful" : "Failed";
            Console.WriteLine("Test multiplication was " + success);

            var c7 = c6 / c1;
            var c7_expected = new Complex(3, -1);

            success = c7.Equal(c7_expected) ? "Successful" : "Failed";
            Console.WriteLine("Test division was " + success);

            Complex compl = 5;
            Console.WriteLine(compl);

            var c10 = new Complex(2);
            var c11 = new Complex(-2);
            var c12 = new Complex(0, 2);
            var c13 = new Complex(0, -2);

            var roots1 = Complex.Sqrt(4);

            success = c10.Equal(roots1[0]) ? "Successful" : "Failed";
            Console.WriteLine("First root of 4 was " + success);
            success = c11.Equal(roots1[1]) ? "Successful" : "Failed";
            Console.WriteLine("Second root of 4 was " + success);

            var roots2 = Complex.Sqrt(-4);

            success = c12.Equal(roots2[0]) ? "Successful" : "Failed";
            Console.WriteLine("First root of -4 was " + success);
            success = c13.Equal(roots2[1]) ? "Successful" : "Failed";
            Console.WriteLine("Second root of -4 was " + success);
        }

        static void Zadatak2Tests()
        {
            var test1 = new QuadraticEquation(1, 2, -3);
            var expectedRoots = new double[] { 1d, -3d };

            Console.WriteLine("Test 1");
            TestingRoots(expectedRoots, test1.Roots);

            Console.WriteLine("Test 2");
            var test2 = new QuadraticEquation(-1, 2, -1);
            expectedRoots = new double[] { 1d, 1d };

            TestingRoots(expectedRoots, test2.Roots);


            Console.WriteLine("Test 3");
            var test3 = new QuadraticEquation(1, 0, 1);
            expectedRoots = new double[] { 0d, 0d };

            TestingRoots(expectedRoots, test3.Roots);
        }

        static void TestingRoots(double[] expectedRoots, double[] appRoots)
        {
            for (int i = 0; i < expectedRoots.Length; i++)
            {
                if (appRoots[i] == expectedRoots[i])
                {
                    Console.WriteLine($" korijeni su isti {appRoots[i]} {expectedRoots[i]}");
                }
                else
                {
                    Console.WriteLine($" korijeni NISU isti {appRoots[i]} {expectedRoots[i]}");
                }
            }
        }
    }
}
