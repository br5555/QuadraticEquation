using System;

namespace QuadraticEquation
{
    public class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException()
        {
        }
        public NotRealRootsException(string message) : base(message)
        {
        }
    }
}