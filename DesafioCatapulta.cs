using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            int pedras = 4, bateria, minutos, pedrasLascadas;

        Console.WriteLine("Digite a duração da bateria");
        minutos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de  bateria");
        bateria = int.Parse(Console.ReadLine());

        pedrasLascadas = minutos * pedras * bateria;
        Console.WriteLine($"A quantidade de pedras Lançadas será de: {pedrasLascadas}.");
        }
    }
}
