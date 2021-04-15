using System;

namespace P1.NET.exceptions
{
    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException()
        {

        }
        public InvalidQuantityException(string message) : base(message) 
        {

        }
    }
}