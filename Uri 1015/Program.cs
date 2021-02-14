using System;
using System.Globalization;
namespace Uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, d, d1,raiz;

            Console.WriteLine();
            Console.Write("Digite os valores do x1 e y1 : ");
            string[] vetor = Console.ReadLine().Split(' ');
            x1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite os valores do x2 e y2 : ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vetor1[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vetor1[1], CultureInfo.InvariantCulture);

            d = Math.Pow((x2 - x1), 2);
            d1 = Math.Pow((y2 - y1), 2);

            raiz = d + d1;

            raiz = Math.Sqrt(raiz);

            Console.WriteLine();
            Console.Write("A Raiz quadrada dos valores é : "+raiz.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}
