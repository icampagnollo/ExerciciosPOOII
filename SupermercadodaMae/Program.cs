using System;

namespace SupermercadoDaMae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis para armazenar os totais
            double totalCesta = 0;
            double totalLimpeza = 0;
            double totalAlimentacao = 0;
            double totalHigiene = 0;

            Console.WriteLine("Bem-vindo ao Supermercado da Mãe!");
            Console.WriteLine("Informe o preço e o código de 20 mercadorias da cesta básica.");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"\nMercadoria {i}:");

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Código ('L' ou 'l'para Limpeza, 'A' ou 'a' para Alimentação, 'H' ou 'h' para Higiene): ");
                char codigo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); 

               
                totalCesta += preco;

                switch (codigo)
                {
                    case 'L':
                        totalLimpeza += preco;
                        break;
                    case 'A':
                        totalAlimentacao += preco;
                        break;
                    case 'H':
                        totalHigiene += preco;
                        break;
                    default:
                        Console.WriteLine("Código inválido! Use apenas 'L' ou 'l', 'A' ou 'a', 'H' ou 'h'.");
                        i--; 
                        break;
                }
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Preço total da cesta básica: R$ {totalCesta.ToString("F2")}");
            Console.WriteLine($"Total em Limpeza: R$ {totalLimpeza.ToString("F2")}");
            Console.WriteLine($"Total em Alimentação: R$ {totalAlimentacao.ToString("F2")}");
            Console.WriteLine($"Total em Higiene: R$ {totalHigiene.ToString("F2")}");
        }
    }
}