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

            double volume = Math.PI * Math.Pow(r, 2) * a;
            double area = 2 * Math.PI * r * (r + a);

            Console.WriteLine(volume);
            Console.WriteLine(area);
        }
    }
}
