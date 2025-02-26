using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro:");            
            string str = Console.ReadLine();
            sbyte a = sbyte.Parse(str);

            sbyte b = --a;
            sbyte c = ++a;            

            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
