using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere o valor da altura do cilindro:");            
            string altura = Console.ReadLine();
            double a = double.Parse(altura);

            Console.WriteLine("Insere o valor do raio do cilindro:");            
            string raio = Console.ReadLine();
            double r = double.Parse(raio);
        }
    }
}
