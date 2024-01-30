using System;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer Types
            int integerNumber = 10;
            long longNumber = 1000000000L;
            short shortNumber = 100;
            byte byteNumber = 200;
            sbyte sbyteNumber = -50;

            Console.WriteLine($"Integer: {integerNumber}");
            Console.WriteLine($"Long: {longNumber}");
            Console.WriteLine($"Short: {shortNumber}");
            Console.WriteLine($"Byte: {byteNumber}");
            Console.WriteLine($"Sbyte: {sbyteNumber}");

            // Floating-Point Types
            float floatNumber = 3.14f;
            double doubleNumber = 3.14159;

            Console.WriteLine($"Float: {floatNumber}");
            Console.WriteLine($"Double: {doubleNumber}");

            // Decimal Type
            decimal decimalNumber = 123.456m;

            Console.WriteLine($"Decimal: {decimalNumber}");

            // Character Types
            char charValue = 'A';

            Console.WriteLine($"Char: {charValue}");

            // Boolean Type
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine($"Boolean (True): {isTrue}");
            Console.WriteLine($"Boolean (False): {isFalse}");

            // String Type
            string stringValue = "Hello, World!";

            Console.WriteLine($"String: {stringValue}");
        }
    }
}
