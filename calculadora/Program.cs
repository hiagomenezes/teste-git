using System;
using System.Globalization;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);
            
            Console.WriteLine("Circunferencia: " + circ.ToString("n2", CultureInfo.InvariantCulture));
            Console.WriteLine("volume: " + vol.ToString("n2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + calc.Pi.ToString("n2", CultureInfo.InvariantCulture));
        }
    }
}
