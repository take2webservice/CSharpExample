using System;

namespace CsharpExample.Type.ClassSample
{
    class GenericsSample<T>
    {
        private T genericValue;

        public GenericsSample(T value)
        {
            this.genericValue = value;
        }

        public T Print(T genericArgument)
        {
            Console.WriteLine($"genericValue: {this.genericValue}");
            Console.WriteLine($"genericArgument: {genericArgument}");
            return genericArgument;
        }
    }
}