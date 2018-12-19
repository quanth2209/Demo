using System;

namespace Demo.Core.Exceptions
{
    public class DemoException : Exception
    {
        public DemoException(string message) : base(message)
        {
        }
    }
}
