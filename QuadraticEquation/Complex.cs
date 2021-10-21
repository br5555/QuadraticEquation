using System;

namespace QuadraticEquation
{
    public struct Complex
    {
        private double real;
        private double imaginary;

        public double Re
        {
            get
            {
                return real;
            }
            set
            {
                real = value;
            }
        }

        public double Im {
            get
            {
                return imaginary;
            }
            set
            {
                imaginary = value;
            }
        }


        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        public Complex(double real)
        {
            this.real = real;
            imaginary = 0d;
        }


        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex((c1.Re * c2.Re) - (c1.Im * c2.Im), c2.Re * c1.Im + c1.Re * c2.Im);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(((c1.Re * c2.Re) + (c1.Im * c2.Im))/(Math.Pow(c2.Re, 2) + Math.Pow(c2.Im, 2)), (c2.Re * c1.Im - c1.Re * c2.Im) / (Math.Pow(c2.Re, 2) + Math.Pow(c2.Im, 2)));
        }

        public static implicit operator Complex(double number)
        {
            return new Complex(number);
        }

        public bool Equal(Complex comp2)
        {
            return Re == comp2.Re && Im == comp2.Im;
        }

        public static Complex[] Sqrt(double number)
        {
            if (number >= 0.0d)
            {
                return new Complex[] { new Complex(Math.Sqrt(number)), new Complex(-Math.Sqrt(number)) };
            }

            return new Complex[] { new Complex(0, Math.Sqrt(-1 * number)), new Complex(0,-1 * Math.Sqrt(-1 * number)) };
        }


        public override string ToString()
        {
            var oper = Im < 0 ? "" : "+";
            return $"{Re} {oper} {Im}";
        }
    }
}