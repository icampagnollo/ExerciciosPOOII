namespace VeraoCapixaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Digite 'c' para começar a conversão por Celsius, ou 'f' para Fahrenheit, ou 'k' para Kelvin! Lembrando que irei converter para as duas temperaturas restantes! :)");
            string escolha = Console.ReadLine();

            if(escolha ==  "c")
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

                float celsius = (fahrenheit - 32f)/ 1.8f;
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

            else
            {
                Console.WriteLine("Não entendiApenas 'c', 'f' ou 'k'.");
            }
        }
    }
}
