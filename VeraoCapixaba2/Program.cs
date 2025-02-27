using System;

namespace VeraoCapixaba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Digite 'c' para começar a conversão por Celsius, ou 'f' para Fahrenheit, ou 'k' para Kelvin! Lembrando que irei converter para as duas temperaturas restantes! :) Ou digite 'media' para calcular a temperatura média do verão capixaba.");
            string escolha = Console.ReadLine();

            if (escolha == "c")
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                float celsius = float.Parse(Console.ReadLine());

                float fahrenheit = celsius * 1.8f + 32f;
                float kelvin = celsius + 273.15f;

                Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit);
                Console.WriteLine("A temperatura em Kelvin é " + kelvin);
            }

            else if (escolha == "f")
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                float fahrenheit = float.Parse(Console.ReadLine());

                float celsius = (fahrenheit - 32f) / 1.8f;
                float kelvin = celsius + 273.15f;

                Console.WriteLine("A temperatura em Celsius é " + celsius);
                Console.WriteLine("A temperatura em Kelvin é " + kelvin);
            }

            else if (escolha == "k")
            {
                Console.WriteLine("Digite a temperatura em Kelvin: ");
                float kelvin = float.Parse(Console.ReadLine());

                float celsius = kelvin - 273.15f;
                float fahrenheit = celsius * 1.8f + 32;

                Console.WriteLine("A temperatura em Celsius é " + celsius);
                Console.WriteLine("A temperatura em Fahrenheit é " + fahrenheit);
            }

            else if (escolha == "media")
            {
                int dias = 15;
                float somaTemperaturas = 0;
                int diaAtual = 1;

                Console.WriteLine("Vamos calcular a temperatura média do verão capixaba!");

                while (diaAtual <= dias)
                {
                    Console.WriteLine($"Digite a temperatura do dia {diaAtual} (em Celsius):");
                    float temperatura = float.Parse(Console.ReadLine());

                    if (temperatura > 28)
                    {
                        somaTemperaturas += temperatura;
                        diaAtual++;
                    }
                    else
                    {
                        Console.WriteLine("Temperatura inválida! No verão capixaba, as temperaturas são acima de 28 °C :/ Digite novamente, por favor! :)");
                    }
                }

                float media = somaTemperaturas / dias;
                Console.WriteLine($"A temperatura média do verão capixaba foi de {media.ToString("F2")} °C.");
            }

            else
            {
                Console.WriteLine("Não entendi. Apenas 'c', 'f', 'k' ou 'media'.");
            }
        }
    }
}