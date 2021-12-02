using System;
using System.Globalization;



namespace Exercicio1_Formatado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            int idade = 30;
            int codigo = 5290;
            String genero = "M";
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            //Usando os valores das variáveis, produza a seguinte saída na tela do console:

            //Produtos:
            //Computador, cujo preço é $ 2100,00
            //Mesa de escritório, cujo preço é $ 650,20

            //Registro: 30 anos de idade, código 5290 e gênero M


            //Medida com oito casas decimais: 53,23456700
            //Arredondado(três casas decimais): 53,235
            //Separador decimal invariant culture: 53.235


            Console.WriteLine("Produtos");

            Console.WriteLine($"O {produto1} custa {preco1:C}");
            Console.WriteLine($"O {produto2} custa {preco2:C}");

            Console.WriteLine("Registro");
            Console.WriteLine($"O cliente de código{codigo} tem {idade} anos de idade e é do gênero {genero}");

            Console.WriteLine("Medidas");
            Console.WriteLine($"Medida com 8 casas decimais {medida}");
            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
