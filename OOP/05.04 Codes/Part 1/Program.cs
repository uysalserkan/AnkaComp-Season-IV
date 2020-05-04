using System;

namespace _05._04_Codes
{
    public delegate int Operation(int x, int y);
    class Program
    {
        static int sum(int x, int y) { return x + y; }
        static int mul(int x, int y) { return x * y; }
        static void display(int x, int y, Operation op) { Console.WriteLine("Operation: " + op(x, y)); }
        static void Main(string[] args)
        {
            Operation op1 = sum;
            Console.WriteLine("Op1: " + op1(3, 5));
            Operation op2 = mul;
            Console.WriteLine("Op2: " + op2(2, 5));
            display(2, 7, mul);
        }
    }
}
