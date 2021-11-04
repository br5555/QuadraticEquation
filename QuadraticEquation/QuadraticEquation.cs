using System;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        private double m_a;
        private double m_b;
        private double m_c;

        public QuadraticEquation()
        {
            m_a = 0d;
            m_b = 0d;
            m_c = 0d;
        }

        public QuadraticEquation(double mA, double mB, double mC)
        {
            m_a = mA;
            m_b = mB;
            m_c = mC;
        }

        public double A
        {
            get
            {
                return m_a;
            }
            set
            {
                m_a = value;
            }
        }

        public double B
        {
            get
            {
                return m_b;
            }
            set
            {
                m_b = value;
            }
        }

        public double C
        {
            get
            {
                return m_c;
            }
            set
            {
                m_c = value;
            }
        }

        public double Y(double x)
        {
            return A * Math.Pow(x, 2.0d) + B * x + C;
        }

        public double Discriminant
        {
            get
            {
                return Math.Pow(B, 2.0d) - 4 * A * C;
            }
        }

        public Complex[] RootsComplex
        {
            get
            {
                if (Discriminant < 0)
                {
                    var disk = Complex.Sqrt(Discriminant);
                    return new Complex[]
                        {new Complex( (-1 * B)/ (2 * A),  disk[0].Im / (2 * A)), new Complex( (-1 * B)/ (2 * A), disk[1].Im / (2 * A))};

                }

                if (A == 0)
                {
                    return new Complex[] { new Complex(-C / B), new Complex(-C / B) };
                }

                return new Complex[]
                    { (-1 * B + Math.Sqrt(Discriminant)) / (2 * A), (-1 * B - Math.Sqrt(Discriminant)) / (2 * A) };
            }
        }

        public double[] Roots
        {
            get
            {
                if (Discriminant < 0)
                    throw new NotRealRootsException("Discriminant is less then zero");

                if (A == 0)
                {
                    return new double[] { -C / B, -C / B };
                }

                return new double[]
                    { (-1 * B + Math.Sqrt(Discriminant)) / (2 * A), (-1 * B - Math.Sqrt(Discriminant)) / (2 * A) };
            }
        }


    }
}