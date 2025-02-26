using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo:");            
            string str = Console.ReadLine();
            byte a = byte.Parse(str);

            byte b = (byte)(a / 2);
            byte c = (byte)(a << 3);  
            byte d = (byte)(a ^ 6);
            bool e = a > 10;          

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
