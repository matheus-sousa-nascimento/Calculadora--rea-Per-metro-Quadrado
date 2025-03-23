using System;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero para saber a área e o perímetro do quadrado: ");
            int num = int.Parse(Console.ReadLine());
            int area = num * num;
            int perimetro = num * 4;
            Console.WriteLine("A área do quadrado é " + area + " e o perímetro do quadrado é " + perimetro);
        }
    }
}
